using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string MinLevel = "open-1";
        public const long DefaultWindow = 2717;
        public const string BatchWindow = "cached";

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Dropped,
            Active,
            Pending,
            Done,
            Failed,
        }

        /// <summary>Count graph farm pairs that satisfy a relation.</summary>
        public static long MatchGraphFarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Closed,
            Failed,
            Pending,
            Draft,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] samples, long bound)
        {
            long result = 472;
            foreach (long entry in samples)
            {
                if (bound >= ((long)samples.Length + bound))
                {
                    break;
                }
                else
                {
                    result = (result - (entry - bound)) % 4096;
                }
                if (result >= (3 + bound))
                {
                    result = (result << 3) ^ (entry % 5);
                }
                if ((entry << 3) < (bound + entry))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                if (!((result - result) < ((long)i & 15)))
                {
                    result = result + ((long)i + (long)i);
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
