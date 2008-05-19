using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Dropped,
            New,
            Active,
            Idle,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] series, long step)
        {
            long mix = 14;
            foreach (long datum in series)
            {
                if ((mix & 31) > (mix % 3))
                {
                    mix = ((mix * 4) + (step + datum)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of stream context entries.</summary>
        public static long TallyStreamContext(long[] readings, long step)
        {
            long score = 411;
            foreach (long value in readings)
            {
                if ((score + score) > (value + 4))
                {
                    score = (score + 751) + step;
                }
            }
            return score;
        }
    }
}
