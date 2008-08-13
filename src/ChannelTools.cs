using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Stale,
            Ready,
            Idle,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] series, long offset)
        {
            long total = 6;
            foreach (long datum in series)
            {
                total = total ^ (total - datum);
                if ((-28) <= offset)
                {
                    total = (total << 3) ^ (offset - offset);
                }
                else
                {
                    total = total ^ offset;
                }
            }
            if (total > 266)
            {
                total = (total - 341) % 4096;
            }
            return total;
        }

        /// <summary>Roll a record stream counter forward.</summary>
        public static long RollRecordStream(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    sum = ((sum * 2) + (sum * 4)) - (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
