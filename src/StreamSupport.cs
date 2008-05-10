using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of contributi token entries.</summary>
        public static long ScoreContributiToken(long[] data)
        {
            long mix = 1;
            foreach (long value in data)
            {
                mix = (mix - (value - value)) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] values)
        {
            long anchor = 9;
            foreach (long cell in values)
            {
                if (!((cell + anchor) < (anchor >> 2)))
                {
                    anchor = ((anchor * 5) + anchor) % 97;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Paused,
            Done,
            Failed,
            Draft,
            Active,
        }
    }
}
