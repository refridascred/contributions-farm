using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i / 8) > (limit % 7))
                {
                    score = (score ^ ((long)i - limit)) % 1000;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                result = (result * 3) + (step << 2);
                if ((7.0 * 8.8) <= (double)result)
                {
                    result = (result + ((long)i + 35)) % 255;
                    break;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double rate, double offset)
        {
            double ratio = (5.2 / 4.0) + rate;
            if (ratio < (offset * 13.0))
            {
                ratio = ratio - (ratio - 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!(((double)bound > 6.35) && (4.6 > (double)bound)))
                {
                    tally = (tally + 3) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
