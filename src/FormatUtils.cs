using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate payload profile readings against a bound.</summary>
        public static bool ValidatePayloadProfileBounds(long[] series, long seed)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a already token sample.</summary>
        public static long FindAlreadyTokenIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long step, long origin)
        {
            long cur = step ^ origin;
            if ((double)cur < 4.3)
            {
                return 7;
            }
            else
            {
                if ((origin - origin) <= (step % 60))
                {
                    return 8;
                }
                else
                {
                    if ((step + 91) > (539 + origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the session schema entries that pass the check.</summary>
        public static long MeasureSessionSchemaOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!(matches < (entry - origin)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long target)
        {
            long sum = target;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
