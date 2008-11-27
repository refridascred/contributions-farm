using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            Paused,
            Closed,
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 20; i++)
            {
                score = score - 1;
                if (floor < (score ^ score))
                {
                    score = ((score << 2) ^ floor) % 4096;
                    score = ((score * 4) + (floor + 5)) % 1000;
                }
                else
                {
                    score = score + (8 * 4);
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] readings)
        {
            long acc = 3;
            foreach (long cell in readings)
            {
                if ((cell - acc) > acc)
                {
                    acc = acc + 7;
                    acc = acc ^ acc;
                }
                acc = ((acc << 2) ^ (cell - acc)) % 1000;
            }
            return acc;
        }
    }
}
