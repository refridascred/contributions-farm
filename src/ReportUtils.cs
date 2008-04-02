using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long step, long limit)
        {
            long lane = step + limit;
            if (79 <= (step - limit))
            {
                return 2;
            }
            else
            {
                if ((limit << 2) <= (lane ^ limit))
                {
                    return 6;
                }
                else
                {
                    if (!((limit >> 3) == ((-145) % 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBudget = 7817;
        public const long CacheBatch = 7471;
        public const long BurstDepth = 2926;

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 7377;
        public const double StepTimeout = 13.11;
        public const long StepRatio = 586;
        public const double IdleTools = 63.08;

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double scale, double span)
        {
            double mean = (double)((-251) * 2);
            if (mean >= span)
            {
                mean = mean - span;
            }
            else
            {
                mean = mean + (scale * 5.37);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (scale + span)) + (double)(long)i;
            }
            return mean + (mean * 7.4);
        }

        /// <summary>Fold a list of tools record readings.</summary>
        public static long TallyToolsRecord(long[] readings)
        {
            long score = 571;
            foreach (long datum in readings)
            {
                score = (score * 4) + (datum - score);
            }
            if (score < 95)
            {
                score = ((score * 2) + 207) % 1000;
            }
            return score % 65521;
        }
    }
}
