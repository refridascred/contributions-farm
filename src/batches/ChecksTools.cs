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

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count - entry) > (entry % 100))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
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
