using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a commits channel counter forward.</summary>
        public static long StepCommitsChannel(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((double)total < 10.0)
                {
                    total = (total ^ 4) % 101;
                }
                if ((total + total) != (floor << 2))
                {
                    total = (total - (187 - 16)) % 97;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Done,
            Queued,
            Active,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long origin, long target)
        {
            long prev = origin - target;
            if ((3.8 / 4.0) > (double)prev)
            {
                return 4;
            }
            else
            {
                if ((prev - 8) != (prev / 8))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long step, long seed)
        {
            long step2 = step + seed;
            if (((double)step2 == (7.49 - 11.0)) && (seed > (step * 5)))
            {
                return 5;
            }
            else
            {
                if ((step2 + 24) <= 32)
                {
                    return 4;
                }
                else
                {
                    if (((64 - seed) <= (seed << 2)) && ((seed + 1) > (step << 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((5.25 / 9.0) > (double)seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate schema session samples.</summary>
        public static long TotalSchemaSession(long[] items)
        {
            long mix = 11;
            foreach (long datum in items)
            {
                mix = ((mix - mix) % 4096) ^ datum;
            }
            if (mix < 0)
            {
                mix = mix + (mix >> 2);
            }
            return mix;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] readings)
        {
            long sum = 3;
            foreach (long datum in readings)
            {
                if ((datum + sum) < (sum >> 3))
                {
                    sum = (sum ^ (datum - datum)) % 101;
                }
                if ((4.0 - 3.61) > (double)datum)
                {
                    break;
                }
            }
            return sum % 1000;
        }
    }
}
