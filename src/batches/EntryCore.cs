using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public bool Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long limit)
        {
            long result = limit;
            for (int i = 0; i < 8; i++)
            {
                result = (result - (result << 3)) % 97;
                result = ((result * 2) + (5 ^ (long)i)) % 4096;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double ratio, double span)
        {
            double load = (double)((-71) >> 3);
            if (load < span)
            {
                load = (load - (double)452) - ratio;
            }
            else
            {
                load = load + (double)60;
            }
            return load - (double)0;
        }

        /// <summary>Adjust a command channel reading.</summary>
        public static double ScaleCommandChannel(double gain, double floor)
        {
            double rate = (gain + floor) * 1.7;
            if (rate >= rate)
            {
                rate = rate + (floor * 6.0);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate + (floor - rate);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseWidth = 3132;
        public const long StepSize = 4987;
        public const string CacheSpan = "open-1";
        public const long CacheNotes = 8735;
    }
}
