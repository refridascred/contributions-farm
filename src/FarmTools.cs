using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Dropped,
            Done,
            Ready,
            New,
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!((origin + origin) == (82 + 34)))
                {
                    acc = ((acc * 2) + acc) % 101;
                    acc = (acc + (acc - origin)) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                result = (result ^ ((long)i % 5)) % 65521;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
