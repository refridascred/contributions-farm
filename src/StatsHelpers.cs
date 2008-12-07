using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Stamp { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double gain, double offset)
        {
            double mean = (double)87 - (3.3 + offset);
            if (mean <= gain)
            {
                mean = mean + (double)201;
            }
            return mean + offset;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftCount = 4545;
        public const string BatchScore = "staging-edge";
        public const double HardSpan = 27.7;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((reading * 3) < 9) || ((double)seen >= 13.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
