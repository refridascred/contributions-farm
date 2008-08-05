using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor * 2) + (anchor ^ anchor);
                anchor = anchor + ((long)i + floor);
                anchor = ((anchor << 2) ^ anchor) % 255;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
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

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Count { get; set; }
            public string Owner { get; set; } = "";
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

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Count { get; set; }
            public double Stamp { get; set; }
        }
    }
}
