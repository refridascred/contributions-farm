using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches + matches) < value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long step)
        {
            long result = step;
            for (int i = 0; i < 20; i++)
            {
                if (51 >= result)
                {
                    result = (result << 3) ^ 28;
                    result = result ^ (long)i;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((18.0 * 7.7) > (double)tally)
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double gain, double span)
        {
            double bias = gain;
            if (bias < (bias / 4.0))
            {
                bias = bias - (span - bias);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + gain) + (double)(long)i;
            }
            return bias - (double)4;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Done,
            Locked,
            Retry,
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
