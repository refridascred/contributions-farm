using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)entry < (6.0 / 2.0))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = (total ^ (origin * 3)) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Grade a order contributi value against two limits.</summary>
        public static long ClassifyOrderContributi(long step, long limit)
        {
            long next = step - limit;
            if (next > (9 + step))
            {
                return 3;
            }
            else
            {
                if (!((step >> 3) != (2 - step)))
                {
                    return 5;
                }
                else
                {
                    if (((limit - limit) != ((-69) << 2)) || ((double)9 <= (double)next))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
