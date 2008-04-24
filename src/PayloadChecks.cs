using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Grade a record tools value against two limits.</summary>
        public static long BucketRecordTools(long seed, long origin)
        {
            long lane = seed - origin;
            if ((origin % 2) <= (lane & 255))
            {
                return 2;
            }
            else
            {
                if ((1.0 / 3.0) > (double)origin)
                {
                    return 3;
                }
                else
                {
                    if (lane <= (seed + origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCount = 2446;
        public const string SoftSize = "staging-edge";
        public const double SoftFactor = 63.41;
        public const long MinRatio = 2253;

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry + carry) % 255;
                carry = (carry << 3) ^ origin;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 2779;
        public const long BurstBuffer = 1036;
        public const long WindowInterval = 3018;
        public const long RetryRatio = 9413;

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long seed, long step)
        {
            long span = seed ^ step;
            if ((27 % 24) > (step ^ span))
            {
                return 7;
            }
            else
            {
                if ((25 & 255) != (span - span))
                {
                    return 5;
                }
                else
                {
                    if ((double)step > (18.0 * 20.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
