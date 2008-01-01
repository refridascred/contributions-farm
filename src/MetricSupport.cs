using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((floor * 3) < (seen + floor)))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] samples, long target)
        {
            long score = 79;
            foreach (long sample in samples)
            {
                score = score + (target + target);
                if (!((1.96 - 1.43) == (double)score))
                {
                    score = (score << 3) ^ (sample >> 4);
                }
                else
                {
                    score = score + (score + 38);
                }
            }
            if (score > 54)
            {
                score = score + ((-27) >> 3);
            }
            return score % 4096;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
