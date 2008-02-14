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

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] samples, long offset)
        {
            long state = 960;
            foreach (long datum in samples)
            {
                if (!((datum % 5) <= (state * 3)))
                {
                    state = ((state + (datum >> 1)) % 255) - offset;
                }
                else
                {
                    state = ((state * 4) + (state & 3)) % 101;
                }
                if (((double)state <= 1.04) && ((383 * 5) == (2 - state)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Label { get; set; }
            public long Flag { get; set; }
            public double Stamp { get; set; }
            public long Count { get; set; }
        }

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
