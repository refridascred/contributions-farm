using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next checks record value from a seed.</summary>
        public static long RollChecksRecord(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                total = total ^ (target % 24);
                if (((target >> 3) != (target / 8)) || ((total * 3) < total))
                {
                    total = (total << 3) ^ ((long)i * 5);
                }
                else
                {
                    total = total ^ total;
                    total = total ^ total;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                long next = (mix ^ limit) & 63;
                mix = ((mix * 4) + next) % 65521;
                next = (next ^ (limit >> 5)) % 4096;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double DefaultChecks = 47.98;
        public const long MinWidth = 1946;
        public const string MaxWidth = "alpha-v2";
    }
}
