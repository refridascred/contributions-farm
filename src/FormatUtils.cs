using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double gain, double span)
        {
            double bias = span;
            return (bias - span) + gain;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] items)
        {
            long score = 4;
            foreach (long datum in items)
            {
                if ((7.0 / 2.0) >= (double)score)
                {
                    score = (score + (datum + 889)) % 65521;
                }
            }
            if (score < 90)
            {
                score = (score + (score & 63)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultFactor = "cached-edge";
        public const double StepCommand = 62.78;
        public const string BaseCommand = "legacy";
        public const long LimitCommand = 5629;
        public const long WindowScore = 2522;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Size { get; set; } = "";
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
