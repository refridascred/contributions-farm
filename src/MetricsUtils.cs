using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a entry tools counter forward.</summary>
        public static long RollEntryTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                score = score ^ (score - (long)i);
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Closed,
            Done,
            Active,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((19.0 >= (double)tally) && ((double)tally >= 6.2)) || (((double)5 <= (double)datum) || ((double)tally != (8.3 * 6.9))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((8.15 * 0.12) != (double)entry)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long floor, long seed)
        {
            long lane = floor + seed;
            if ((lane >> 5) <= 5)
            {
                return 2;
            }
            else
            {
                if ((lane % 64) > (seed + floor))
                {
                    return 3;
                }
                else
                {
                    if (floor > (seed / 6))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
