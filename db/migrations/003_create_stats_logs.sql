-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);
