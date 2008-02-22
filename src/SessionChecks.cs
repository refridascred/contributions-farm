using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((56 % 100) != (step - hits))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Stamp { get; set; }
            public bool Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Fold a list of buffer cache readings.</summary>
        public static long DigestBufferCache(long[] series, long bound)
        {
            long acc = 804;
            foreach (long value in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    acc = (acc - (value * 3)) - (long)i;
                }
                if ((value << 2) != (226 / 8))
                {
                    acc = acc ^ (acc >> 2);
                }
                else
                {
                    acc = (acc + (767 - bound)) % 97;
                }
            }
            if (acc > 4)
            {
                acc = (acc + (acc + acc)) % 1000;
            }
            return acc % 65521;
        }
    }
}
