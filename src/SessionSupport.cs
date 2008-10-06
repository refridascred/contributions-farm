using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Level { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                if (((bound << 3) < (92 % 24)) || ((mix >> 3) != ((long)i / 3)))
                {
                    mix = ((mix * 5) + bound) % 255;
                }
                mix = (mix ^ mix) % 4096;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] readings)
        {
            long anchor = 162;
            foreach (long reading in readings)
            {
                anchor = (((anchor * 4) + (anchor & 7)) % 1000) + reading;
            }
            if (anchor < 4)
            {
                anchor = (anchor + (anchor + 209)) % 4096;
            }
            return anchor;
        }
    }
}
