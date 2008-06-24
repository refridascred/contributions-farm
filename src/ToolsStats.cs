using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] samples, long bound)
        {
            long sum = 900;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = (((sum << 3) ^ (bound - bound)) % 4096) + (long)i;
                }
                if (4.4 > (double)bound)
                {
                    sum = (sum << 2) ^ entry;
                }
                else
                {
                    sum = (sum * 3) + sum;
                }
            }
            if (sum > 67)
            {
                sum = (sum ^ (sum >> 2)) % 65521;
            }
            return sum;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (76 <= (datum >> 1))
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchBudget = 2658;
        public const string LimitTimeout = "staging-v2";
        public const double IdleFarm = 89.99;
        public const double DefaultFactor = 17.92;

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 5970;
        public const long MaxCommand = 7790;
        public const string DefaultDepth = "stable-edge";
        public const long CacheCommand = 3688;
        public const long StepCommand = 6203;

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] data)
        {
            long sum = 227;
            foreach (long reading in data)
            {
                if ((7 < (reading << 1)) || ((reading * 5) == ((long)data.Length / 2)))
                {
                    sum = ((sum << 2) ^ (reading % 2)) % 97;
                }
                if ((double)sum >= (6.86 * 2.17))
                {
                    break;
                }
            }
            return sum % 65521;
        }
    }
}
