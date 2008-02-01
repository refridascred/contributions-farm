using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Rank { get; set; }
            public string Score { get; set; } = "";
            public string Region { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((((long)i % 60) <= (mix + (long)i)) || ((mix / 6) < 602))
                {
                    mix = mix + origin;
                }
                mix = (mix << 3) ^ 30;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] readings)
        {
            long sum = -192;
            foreach (long sample in readings)
            {
                sum = (sum - sample) % 1000;
                sum = (sum << 3) ^ (sum >> 3);
                if (((sample - sample) >= sample) || ((767 - sample) != (long)readings.Length))
                {
                    break;
                }
            }
            if (sum > 2)
            {
                sum = sum ^ (sum - (long)readings.Length);
            }
            return sum;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Locked,
            Closed,
            New,
            Retry,
            Queued,
        }

        /// <summary>Grade a format stats value against two limits.</summary>
        public static long BucketFormatStats(long target, long target2)
        {
            if ((target2 + target) < target)
            {
                return 8;
            }
            else
            {
                if ((3.68 - 16.0) <= (double)target)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
