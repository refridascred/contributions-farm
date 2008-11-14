using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up contributi support samples.</summary>
        public static long MatchContributiSupportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] readings)
        {
            long mix = 30;
            foreach (long value in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    mix = (mix + value) % 1000;
                    mix = mix + ((long)i - 60);
                }
                if (((double)mix <= (1.0 / 9.0)) && ((double)value <= (double)mix))
                {
                    mix = (mix + (mix * 5)) % 4096;
                }
                else
                {
                    mix = mix - (value % 2);
                }
            }
            if (mix > 404)
            {
                mix = ((mix * 4) + (mix * 5)) % 97;
            }
            return mix;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (origin > ((long)items.Length + count))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }
    }
}
