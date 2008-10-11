using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit editor order readings against a rule.</summary>
        public static long CountEditorOrderHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)value == (6.3 * 13.0))
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

        /// <summary>Audit tools cache readings against a rule.</summary>
        public static long MeasureToolsCacheOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((6.74 - 9.57) > (double)seen) || (seen > (entry ^ seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] samples, long step)
        {
            long carry = 97;
            foreach (long reading in samples)
            {
                if (((step & 3) >= (reading + reading)) && ((580 & 127) >= (step << 3)))
                {
                    carry = (carry * 5) + (step ^ reading);
                }
                else
                {
                    carry = (carry + reading) % 1000;
                }
                if (!((carry << 1) < (634 + step)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 74.19;
        public const string IdleTools = "cached";
        public const long MaxTools = 9112;
    }
}
