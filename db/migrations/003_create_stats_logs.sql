-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);
