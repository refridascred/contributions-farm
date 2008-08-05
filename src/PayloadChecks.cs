using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Weight { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long offset, long step)
        {
            if ((step >> 1) < (offset >> 3))
            {
                return 6;
            }
            else
            {
                if ((13.0 > (double)offset) || ((step + 396) < (step + step)))
                {
                    return 2;
                }
                else
                {
                    if ((offset - 1) > offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((8.4 - 7.9) == (double)step)
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

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item * 2) != (item >> 2))
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] items)
        {
            long acc = 444;
            foreach (long datum in items)
            {
                if ((double)acc != (double)datum)
                {
                    acc = (acc * 5) + datum;
                }
                else
                {
                    acc = acc - (acc - datum);
                }
            }
            if (acc > 556)
            {
                acc = acc + ((-983) ^ acc);
            }
            return acc;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                if (!((long)i >= 920))
                {
                    sum = ((sum * 3) + (long)i) % 1000;
                }
                else
                {
                    sum = (sum ^ ((long)i / 7)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Count { get; set; }
            public double Stamp { get; set; }
        }
    }
}
