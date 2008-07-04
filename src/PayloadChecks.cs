using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate filter record readings against a bound.</summary>
        public static bool GuardFilterRecordLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!((cell + cell) > (floor + cell)))
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

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long step, long offset)
        {
            long edge = step - offset;
            if (((double)step <= (17.0 - 5.25)) || (4.3 > (double)offset))
            {
                return 0;
            }
            else
            {
                if ((offset + edge) <= (offset & 31))
                {
                    return 5;
                }
                else
                {
                    if ((step + step) == (edge - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step != (7.1 + 4.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long origin, long origin2)
        {
            if ((origin + origin) <= (origin % 2))
            {
                return 3;
            }
            else
            {
                if ((origin * 5) < origin)
                {
                    return 0;
                }
                else
                {
                    if (origin <= (origin2 + origin2))
                    {
                        return 5;
                    }
                    else
                    {
                        if (origin2 >= (origin * 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine editor layout values into a single score.</summary>
        public static long TallyEditorLayout(long[] series)
        {
            long anchor = 4;
            foreach (long reading in series)
            {
                if ((anchor * 2) <= (reading * 3))
                {
                    anchor = ((anchor * 3) + anchor) % 1000;
                }
            }
            if (anchor > 128)
            {
                anchor = ((anchor << 2) ^ (anchor * 4)) % 97;
            }
            return anchor;
        }

        /// <summary>Count the route metrics entries that pass the check.</summary>
        public static long AuditRouteMetricsGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((sample << 1) >= step) && !((7 - sample) >= matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
