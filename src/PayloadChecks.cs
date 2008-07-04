using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 13; i++)
            {
                if ((-359) <= (25 + floor))
                {
                    anchor = ((anchor * 4) + anchor) % 255;
                }
                else
                {
                    anchor = ((anchor << 2) ^ anchor) % 97;
                }
                anchor = (anchor * 5) + (anchor * 5);
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = (anchor ^ (anchor - (long)i)) - (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
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

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
