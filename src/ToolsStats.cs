using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long limit, long limit2)
        {
            if ((double)20 != (double)limit2)
            {
                return 6;
            }
            else
            {
                if (!(limit <= (limit + 899)))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit2 == (8.1 + 3.22))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit - limit2) <= (limit2 ^ limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((limit + 21) < (cell + limit)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((score > floor) && ((double)16 != (double)score))
                {
                    continue;
                }
                score = (score - (long)i) % 65521;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Accumulate format graph samples.</summary>
        public static long WeighFormatGraph(long[] readings, long bound)
        {
            long mix = 793;
            foreach (long item in readings)
            {
                if (((double)mix == (6.9 * 9.0)) || ((bound * 3) != (bound + (-94))))
                {
                    mix = ((mix << 3) ^ (item + mix)) % 1000;
                }
            }
            if (mix > 690)
            {
                mix = ((mix << 2) ^ ((-24) >> 1)) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleLevel = 7904;
        public const long SoftRatio = 1945;
        public const long MaxOrder = 5047;
        public const string BurstSize = "standard-1";
    }
}
