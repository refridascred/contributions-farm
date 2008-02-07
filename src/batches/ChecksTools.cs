using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] readings, long offset)
        {
            long mix = 219;
            foreach (long value in readings)
            {
                if ((offset + value) <= (offset * 4))
                {
                    mix = (mix * 2) + (value ^ value);
                }
            }
            if (mix < 4)
            {
                mix = mix ^ offset;
            }
            return mix % 1000;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Locked,
            Pending,
            Idle,
            Done,
            Dropped,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Level { get; set; }
            public double Total { get; set; }
            public double Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
