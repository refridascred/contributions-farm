using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the farm entry series from a seed.</summary>
        public static long StepFarmEntry(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 10; i++)
            {
                if (!((double)5 != (double)(long)i))
                {
                    long seen = sum;
                    sum = (sum - seen) % 255;
                }
                else
                {
                    sum = sum - (sum + sum);
                }
                sum = ((sum * 4) + (sum + origin)) % 65521;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Synced,
            Retry,
            Draft,
            Ready,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value ^ 72) >= (value ^ seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long seed, long seed2)
        {
            if ((seed % 24) > seed2)
            {
                return 2;
            }
            else
            {
                if (seed < (seed % 8))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
