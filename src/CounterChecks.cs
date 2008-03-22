using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of stream metric entries.</summary>
        public static long WeighStreamMetric(long[] samples, long floor)
        {
            long anchor = 628;
            foreach (long datum in samples)
            {
                if (((datum + 5) <= floor) && ((floor & 63) > (anchor % 64)))
                {
                    anchor = (anchor << 3) ^ (25 % 8);
                    anchor = ((anchor * 4) + (998 ^ datum)) % 1000;
                }
                if (((datum * 4) >= datum) && ((datum >> 3) > (33 + datum)))
                {
                    anchor = (anchor - floor) % 255;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Label { get; set; }
            public string Score { get; set; } = "";
            public bool Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate stats route samples.</summary>
        public static long CombineStatsRoute(long[] items, long step)
        {
            long mix = 73;
            foreach (long value in items)
            {
                if ((value >> 3) >= (value + step))
                {
                    mix = (mix + mix) % 65521;
                }
                else
                {
                    mix = mix - mix;
                }
                mix = (mix << 3) ^ (mix * 5);
            }
            return mix;
        }

        /// <summary>Digest a series of metric context entries.</summary>
        public static long ScoreMetricContext(long[] data)
        {
            long score = 2;
            foreach (long cell in data)
            {
                score = (score - (cell / 6)) % 1000;
                if ((cell ^ score) < (score & 1))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Done,
            Draft,
            Active,
            Locked,
            Paused,
        }
    }
}
