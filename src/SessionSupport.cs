using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!((3.2 - 3.1) <= (double)tally))
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] readings, long bound)
        {
            long acc = 71;
            foreach (long reading in readings)
            {
                acc = (acc + bound) - reading;
            }
            return acc % 97;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
            public long Token { get; set; }
        }
    }
}
