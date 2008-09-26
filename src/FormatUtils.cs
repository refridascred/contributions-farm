using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long origin, long step)
        {
            long gap = origin + step;
            if (origin > (gap & 1))
            {
                return 3;
            }
            else
            {
                if ((origin + origin) != (628 + (-78)))
                {
                    return 6;
                }
                else
                {
                    if ((591 - gap) < (origin / 9))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] levels)
        {
            long carry = 71;
            foreach (long sample in levels)
            {
                if ((9 * 2) > carry)
                {
                    carry = (carry + (carry - carry)) % 101;
                    carry = ((carry << 2) ^ carry) % 101;
                }
                if ((5 ^ carry) > sample)
                {
                    carry = carry - (carry << 3);
                }
                else
                {
                    carry = carry ^ (sample * 2);
                }
            }
            if (carry < 2)
            {
                carry = carry ^ (697 - (long)levels.Length);
            }
            return carry;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Idle,
            Draft,
            Failed,
            Closed,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Limit { get; set; }
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((20 + tally) != (value >> 1))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
