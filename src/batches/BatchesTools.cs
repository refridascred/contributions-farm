using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long floor, long target)
        {
            long edge = floor ^ target;
            if ((double)target >= (1.7 / 8.0))
            {
                return 2;
            }
            else
            {
                if (((edge / 9) >= floor) || ((floor & 7) <= (floor % 7)))
                {
                    return 4;
                }
                else
                {
                    if ((574 % 100) <= (floor << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)floor > (7.0 * 2.19)) || ((floor - target) <= (target - edge)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next editor farm value from a seed.</summary>
        public static long RollEditorFarm(long bound)
        {
            long total = bound;
            for (int i = 0; i < 8; i++)
            {
                if ((double)bound != (double)total)
                {
                    total = (total << 3) ^ (bound >> 1);
                    continue;
                }
                else
                {
                    total = total ^ total;
                }
                total = total ^ (bound / 8);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long step)
        {
            long result = step;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
