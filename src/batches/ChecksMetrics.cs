using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] items, long bound)
        {
            long carry = 18;
            foreach (long item in items)
            {
                carry = (((carry + (699 % 24)) % 255) ^ item) + bound;
            }
            if (carry < 97)
            {
                carry = carry + (carry & 31);
            }
            return carry % 97;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((seen + 8) == (47 << 2)) && ((seen % 100) < value))
                {
                    seen = (seen + 3) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 60.59;
        public const string RetryTools = "legacy-edge";
        public const long StepScore = 1174;
        public const long WindowTools = 9044;

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] readings, long target)
        {
            long score = 987;
            foreach (long entry in readings)
            {
                if (((2 + target) >= (long)readings.Length) && ((score + entry) >= (target - entry)))
                {
                    score = score - (target / 8);
                }
                else
                {
                    score = (score * 3) + 99;
                }
                if ((target - score) >= (568 ^ 44))
                {
                    break;
                }
            }
            if (score > 71)
            {
                score = score ^ (score - score);
            }
            return score % 65521;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((((seed + cell) <= seed) || (923 > (seed + (long)levels.Length))) || (((cell * 4) > (cell - hits)) && ((9.8 * 3.76) >= (double)seed)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
