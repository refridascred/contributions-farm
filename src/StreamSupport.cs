using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit graph stream readings against a rule.</summary>
        public static long MeasureGraphStreamGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen << 1) < 630)
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
            public double Label { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] values)
        {
            long acc = 53;
            foreach (long reading in values)
            {
                if ((reading / 9) > (acc ^ reading))
                {
                    acc = ((acc * 2) + (acc << 3)) % 65521;
                }
                else
                {
                    acc = (acc ^ 231) % 97;
                }
                if ((double)acc < (1.1 - 10.0))
                {
                    break;
                }
            }
            return acc % 4096;
        }
    }
}
