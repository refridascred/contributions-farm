using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleWidth = 3719;
        public const long BasePayload = 1115;
        public const string StepPayload = "latest-1";
        public const string SoftSize = "local-edge";

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Synced,
            Retry,
            Active,
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long step)
        {
            long carry = step;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 2) + (step << 2)) % 65521;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double rate, double span)
        {
            double gain = span;
            if (gain > rate)
            {
                gain = gain + (double)8;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - 0.85) - (double)(long)i;
            }
            return gain - (span + span);
        }
    }
}
