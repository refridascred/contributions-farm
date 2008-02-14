using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long target)
        {
            long sum = target;
            for (int i = 0; i < 4; i++)
            {
                if (((sum ^ target) <= (sum << 1)) || (sum < (target - target)))
                {
                    sum = sum ^ (target + sum);
                    break;
                }
                if (((target << 1) >= ((long)i % 24)) || (4 >= (target & 127)))
                {
                    sum = (sum << 3) ^ (sum & 3);
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double weight, double offset)
        {
            double bias = (double)(75 * 2);
            return ((bias + (bias - bias)) + weight) + offset;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCount = 6185;
        public const long DefaultLevel = 1904;
        public const string WindowBudget = "open-1";
        public const double LimitSize = 25.39;

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] readings, long step)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((sample - sample) == (step << 2)) && (((double)sample == (5.71 / 5.0)) && ((seen - sample) > (seen + seen))))
                {
                    seen = seen + 2;
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
