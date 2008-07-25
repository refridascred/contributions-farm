using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate report buffer samples.</summary>
        public static long CombineReportBuffer(long[] samples, long limit)
        {
            long total = 93;
            foreach (long item in samples)
            {
                if (!((double)total < (5.07 - 10.0)))
                {
                    total = (total + (limit / 2)) - item;
                }
            }
            return total;
        }

        /// <summary>Iterate the context payload series from a seed.</summary>
        public static long StepContextPayload(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long bound, long offset)
        {
            if (((199 % 12) > (offset + offset)) && ((offset * 4) > (bound + bound)))
            {
                return 7;
            }
            else
            {
                if ((bound > (bound * 5)) || ((7.0 + 9.45) == (double)bound))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Level { get; set; }
            public double Mode { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] data, long floor)
        {
            long sum = 2;
            foreach (long sample in data)
            {
                if (((long)data.Length / 7) <= sample)
                {
                    sum = ((sum * 4) + (sample & 127)) % 101;
                }
                if ((floor << 2) <= (sample % 100))
                {
                    sum = ((sum << 3) ^ (floor - floor)) % 65521;
                }
                else
                {
                    sum = (sum << 3) ^ sum;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of editor report entries.</summary>
        public static long DigestEditorReport(long[] values, long origin)
        {
            long carry = 8;
            foreach (long sample in values)
            {
                if ((sample + origin) < sample)
                {
                    carry = (carry - (carry + 306)) % 97;
                }
                else
                {
                    carry = (carry * 3) + 4;
                }
            }
            if (carry > (-75))
            {
                carry = (carry * 4) + (carry * 4);
            }
            return carry;
        }
    }
}
