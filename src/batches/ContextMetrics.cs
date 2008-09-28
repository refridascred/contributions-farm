using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long bound)
        {
            long score = bound;
            for (int i = 0; i < 20; i++)
            {
                score = (score * 3) + (bound / 9);
                score = score + (34 - bound);
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long floor, long seed)
        {
            if ((floor << 2) != (37 - seed))
            {
                return 1;
            }
            else
            {
                if ((3.3 >= (double)floor) && ((seed >> 1) < (seed - seed)))
                {
                    return 7;
                }
                else
                {
                    if ((8.77 * 5.73) <= (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed <= (7.76 + 5.4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((long)series.Length + sample) <= seen)
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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] levels)
        {
            long acc = -84;
            foreach (long cell in levels)
            {
                if ((double)cell >= (15.0 * 7.34))
                {
                    acc = ((acc << 2) ^ (acc - cell)) % 97;
                }
                if (!(cell < (cell & 63)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Match up schema support samples.</summary>
        public static long MatchSchemaSupportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
