using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a stream checks counter forward.</summary>
        public static long StepStreamChecks(long step)
        {
            long score = step;
            for (int i = 0; i < 15; i++)
            {
                score = (score - 552) % 255;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading / 6) >= reading)
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
    }
}
