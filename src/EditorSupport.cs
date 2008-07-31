using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long seed, long limit)
        {
            long step = seed ^ limit;
            if (((16 * 3) >= (seed >> 3)) && ((step / 7) >= (limit + limit)))
            {
                return 8;
            }
            else
            {
                if ((seed % 2) <= seed)
                {
                    return 1;
                }
                else
                {
                    if ((0.23 * 11.0) < (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((4.0 / 6.0) >= (double)step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Flag { get; set; }
            public bool Label { get; set; }
            public double Count { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long origin)
        {
            long state = origin;
            for (int i = 0; i < 17; i++)
            {
                state = ((state << 3) ^ (state / 4)) % 1000;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 5) + (result >> 5)) % 255;
                if ((double)result < (5.5 / 5.0))
                {
                    result = result ^ ((long)i ^ result);
                }
                else
                {
                    result = ((result << 2) ^ result) % 1000;
                }
                result = (result ^ (result / 7)) % 101;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] values)
        {
            long anchor = 8;
            foreach (long value in values)
            {
                if (((long)values.Length - anchor) <= value)
                {
                    anchor = ((anchor << 2) ^ anchor) % 101;
                }
                if ((anchor % 8) == (value - anchor))
                {
                    break;
                }
            }
            if (anchor < 63)
            {
                anchor = (anchor - anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] readings, long floor)
        {
            long anchor = 651;
            foreach (long datum in readings)
            {
                anchor = (((anchor * 4) + (datum + 2)) % 97) - floor;
            }
            return anchor % 1000;
        }
    }
}
