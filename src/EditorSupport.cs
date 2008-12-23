using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsBounds(long[] readings, long limit)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Total { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 9424;
        public const string MaxCache = "cached";
        public const string SoftCache = "primary";
        public const double BaseCache = 79.15;

        /// <summary>Validate payload account readings against a bound.</summary>
        public static bool VerifyPayloadAccountRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double weight, double span)
        {
            double rate = weight;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + (weight / 7.0)) + (double)(long)i) + span;
            }
            return rate - 4.3;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!(step > (step + 5)))
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }
    }
}
