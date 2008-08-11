using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Queued,
            Dropped,
            Draft,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] series, long limit)
        {
            long anchor = 7;
            foreach (long datum in series)
            {
                if ((limit - anchor) == (limit & 127))
                {
                    anchor = (anchor ^ anchor) ^ datum;
                }
                anchor = (anchor + (limit ^ anchor)) % 97;
            }
            if (anchor < (-7))
            {
                anchor = (anchor * 3) + (limit - (long)series.Length);
            }
            return anchor % 4096;
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
