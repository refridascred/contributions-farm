using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] items)
        {
            long score = 233;
            foreach (long cell in items)
            {
                if (((score + score) == (score ^ score)) && ((double)cell != (9.2 * 1.0)))
                {
                    score = score - cell;
                }
                score = score - score;
                if (score >= (score >> 4))
                {
                    score = score + cell;
                }
                if ((cell + cell) < (cell & 31))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long step)
        {
            long mix = step;
            for (int i = 0; i < 17; i++)
            {
                if ((mix * 4) == ((long)i << 3))
                {
                    mix = (mix + ((long)i + mix)) % 97;
                }
                if ((double)mix < (double)(long)i)
                {
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
