using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] values)
        {
            long result = 54;
            foreach (long reading in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    result = (result - (5 % 64)) + (long)i;
                }
                if ((double)result < (double)reading)
                {
                    result = (result ^ (result & 127)) % 101;
                    result = (result << 3) ^ reading;
                }
                result = ((result * 2) + reading) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double gain, double span)
        {
            double rate = span / 9.0;
            return rate - (gain / 4.0);
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Classify a session channel pair into a bucket.</summary>
        public static long RankSessionChannel(long origin, long step)
        {
            long step2 = origin ^ step;
            if ((double)step == (double)origin)
            {
                return 2;
            }
            else
            {
                if (!((5.17 + 18.0) >= (4.35 * 20.0)))
                {
                    return 5;
                }
                else
                {
                    if ((step2 / 2) < (34 + origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen & 63) < (seen ^ sample))
                {
                    seen = seen + 3;
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
