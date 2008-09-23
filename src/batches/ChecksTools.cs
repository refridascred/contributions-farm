using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] samples, long bound)
        {
            long carry = -34;
            foreach (long entry in samples)
            {
                if (7 <= (entry * 3))
                {
                    carry = carry - (bound - entry);
                }
                else
                {
                    carry = (carry - (bound << 2)) % 1000;
                }
                if (((carry >> 3) < (entry + entry)) || (entry < (entry - bound)))
                {
                    break;
                }
            }
            if (carry < 207)
            {
                carry = (carry * 2) + (carry + carry);
            }
            return carry % 1000;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                if (((offset * 4) == (offset * 5)) || ((mark * 2) <= (mark * 5)))
                {
                    mark = (mark << 3) ^ (18 ^ offset);
                }
                else
                {
                    mark = ((mark * 3) + ((-109) & 3)) % 97;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long step, long step2)
        {
            long lane = step ^ step2;
            if ((step + lane) > (lane ^ step))
            {
                return 8;
            }
            else
            {
                if (!(step2 > (step2 ^ lane)))
                {
                    return 4;
                }
                else
                {
                    if (step <= lane)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Token { get; set; }
            public string Label { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
