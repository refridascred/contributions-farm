using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] values)
        {
            long mix = 46;
            foreach (long datum in values)
            {
                if (((mix >> 2) < (mix - mix)) || ((mix >> 5) != (mix + 610)))
                {
                    mix = (mix - (9 - mix)) ^ datum;
                }
            }
            if (mix < (-63))
            {
                mix = (mix * 4) + mix;
            }
            return mix;
        }

        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double bias, double floor)
        {
            double scale = (double)6 / 5.0;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (floor * 15.0)) + (double)(long)i;
            }
            return scale + (bias + scale);
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Score { get; set; } = "";
            public bool Ratio { get; set; }
            public long Mode { get; set; }
        }
    }
}
