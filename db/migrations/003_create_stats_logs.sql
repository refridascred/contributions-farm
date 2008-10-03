-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);
