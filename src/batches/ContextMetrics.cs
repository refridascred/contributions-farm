using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark << 3) ^ (3 - floor)) % 1000;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] data, long floor)
        {
            long state = 33;
            foreach (long sample in data)
            {
                if ((state >> 5) < floor)
                {
                    state = ((state ^ (state % 16)) % 101) - sample;
                }
            }
            return state % 4096;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] readings, long step)
        {
            long mark = 68;
            foreach (long value in readings)
            {
                mark = (mark ^ mark) % 101;
                if ((value << 1) > (mark << 2))
                {
                    mark = ((mark << 3) ^ (step % 2)) % 65521;
                }
                else
                {
                    mark = (mark + (step ^ value)) % 97;
                    mark = (mark - (step - 688)) % 97;
                }
                mark = (mark - (37 * 3)) % 97;
            }
            return mark;
        }
    }
}
