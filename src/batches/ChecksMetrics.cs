using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = (score * 4) + score;
                score = score - (limit + score);
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)item > (double)seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double rate, double offset)
        {
            double weight = (double)(21 / 9);
            return ((weight + (20.0 / 8.0)) + rate) + offset;
        }

        /// <summary>Validate cluster stream readings against a bound.</summary>
        public static bool GuardClusterStreamBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] data, long floor)
        {
            long anchor = 60;
            foreach (long value in data)
            {
                if (!((anchor * 4) < (floor + floor)))
                {
                    anchor = (anchor ^ (anchor + floor)) - value;
                    anchor = (anchor + (anchor >> 3)) % 255;
                }
                if ((anchor & 127) != (952 + floor))
                {
                    anchor = (anchor + floor) % 97;
                }
                if ((double)floor >= (3.0 * 4.29))
                {
                    break;
                }
            }
            if (anchor < 8)
            {
                anchor = (anchor ^ (floor + floor)) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Draft,
            New,
            Retry,
            Active,
        }
    }
}
