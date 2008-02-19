-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    owner TEXT NOT NULL,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);
