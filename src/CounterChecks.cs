using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            New,
            Paused,
            Synced,
            Stale,
            Idle,
        }

        /// <summary>Accumulate layout token samples.</summary>
        public static long WeighLayoutToken(long[] values, long offset)
        {
            long anchor = 34;
            foreach (long value in values)
            {
                if (((double)anchor <= (double)97) || ((double)anchor < 9.0))
                {
                    anchor = anchor ^ (offset / 9);
                }
                else
                {
                    anchor = anchor + (value + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Find the first editor checks entry that matches the target.</summary>
        public static long LocateEditorChecksIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cluster format measurements.</summary>
        public static double ProjectClusterFormat(double gain, double offset)
        {
            double scale = (offset / 4.0) + (gain - gain);
            if (scale < (scale + scale))
            {
                scale = scale - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + gain) + (double)(long)i;
            }
            return scale - (7.2 - gain);
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] samples, long offset)
        {
            long sum = 685;
            foreach (long value in samples)
            {
                bool ready = (offset - sum) == (5 + 5);
                if (!(((double)sum == (5.8 + 9.91)) && ready))
                {
                    ready = (value / 7) < (82 % 12);
                }
                if (((value >> 3) >= (sum + 230)) || ((75 ^ value) >= (offset << 3)))
                {
                    sum = ((sum << 3) ^ value) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Combine cache editor values into a single score.</summary>
        public static long CombineCacheEditor(long[] readings)
        {
            long anchor = 61;
            foreach (long reading in readings)
            {
                if ((reading * 4) == (anchor + reading))
                {
                    anchor = ((anchor * 5) + (9 * 5)) % 101;
                }
                else
                {
                    anchor = (anchor << 3) ^ anchor;
                }
            }
            return anchor;
        }
    }
}
