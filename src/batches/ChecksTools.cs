using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] series)
        {
            long mix = 176;
            foreach (long datum in series)
            {
                if (((datum - datum) <= (datum - (long)series.Length)) || ((double)mix == (double)datum))
                {
                    mix = (mix - mix) % 97;
                }
                if (((205 + 50) < (datum + 74)) && (datum < (mix * 5)))
                {
                    break;
                }
            }
            if (mix < 412)
            {
                mix = ((mix * 3) + mix) % 101;
            }
            return mix;
        }

        /// <summary>Match up support queue samples.</summary>
        public static long OverlapSupportQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Offset { get; set; }
            public bool Level { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
