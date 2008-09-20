using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double rate, double floor)
        {
            double load = floor / 9.0;
            if (load < 6.0)
            {
                load = load - (rate + load);
            }
            return load + rate;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double bias, double offset)
        {
            double scale = (bias * 2.3) - (5.3 / 7.0);
            return (scale - (double)99) + offset;
        }

        /// <summary>Scale a buffer command figure with a bias.</summary>
        public static double BlendBufferCommand(double bias, double offset)
        {
            double drift = (double)((-3) * 2);
            if (drift < drift)
            {
                drift = (drift + (offset * 13.0)) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + 9.67) + (double)(long)i;
            }
            return drift + (offset - drift);
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long offset, long floor)
        {
            if ((offset + floor) <= floor)
            {
                return 2;
            }
            else
            {
                if ((floor / 5) > (floor << 2))
                {
                    return 5;
                }
                else
                {
                    if (6.0 <= (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Weight { get; set; }
            public string Stamp { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
