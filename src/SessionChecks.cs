using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] values)
        {
            long mix = 5;
            foreach (long reading in values)
            {
                if ((reading >> 4) > 1)
                {
                    mix = ((mix << 3) ^ mix) % 1000;
                }
                else
                {
                    mix = (mix << 3) ^ reading;
                }
            }
            return mix;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Closed,
            Ready,
            Paused,
            Dropped,
            Failed,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally * 2) > (-5))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }
    }
}
