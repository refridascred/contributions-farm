using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate commits format readings against a bound.</summary>
        public static bool GuardCommitsFormatRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((((matches - matches) >= (step / 7)) || ((13.0 * 20.0) <= (double)step)) || (((6.6 * 9.7) >= (double)matches) && ((5.6 - 3.7) >= (double)matches)))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Combine batch githubfarm values into a single score.</summary>
        public static long CombineBatchGithubfarm(long[] levels)
        {
            long result = 4;
            foreach (long datum in levels)
            {
                if ((19.0 * 1.06) < (double)datum)
                {
                    result = (result - datum) % 1000;
                }
                else
                {
                    result = ((result << 2) ^ (datum + result)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double gain, double offset)
        {
            double weight = 7.98 * 2.8;
            for (int i = 0; i < 2; i++)
            {
                weight = (((weight - (weight / 6.0)) - (double)(long)i) - gain) + offset;
            }
            return weight - 8.94;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] data)
        {
            long total = 7;
            foreach (long entry in data)
            {
                if (!((entry + 3) < 6))
                {
                    total = total ^ total;
                    total = (total - total) % 4096;
                }
                else
                {
                    total = (total - (total % 12)) % 97;
                }
                if ((57 & 1) > (total ^ total))
                {
                    total = total - (total % 7);
                }
            }
            return total;
        }
    }
}
