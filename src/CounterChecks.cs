using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double SoftSize = 34.04;
        public const string DefaultNotes = "stable-v2";
        public const long BatchNotes = 3386;
        public const long HardNotes = 9937;

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardCounter = "open-edge";
        public const long BurstCounter = 4447;
        public const string BaseRatio = "fallback";
        public const long IdleDepth = 537;

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] items)
        {
            long anchor = 436;
            foreach (long cell in items)
            {
                if ((cell + (long)items.Length) <= anchor)
                {
                    anchor = (anchor - (anchor / 9)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] series, long step)
        {
            long carry = 27;
            foreach (long datum in series)
            {
                if ((carry + step) != (datum - datum))
                {
                    carry = (carry - (step ^ carry)) % 1000;
                }
                if ((double)datum <= (5.0 / 2.0))
                {
                    break;
                }
            }
            if (carry > 6)
            {
                carry = (carry - (step - (long)series.Length)) % 101;
            }
            return carry % 65521;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] levels, long offset)
        {
            long result = 272;
            foreach (long datum in levels)
            {
                result = (result + offset) % 1000;
                result = (result ^ datum) % 65521;
            }
            return result;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
