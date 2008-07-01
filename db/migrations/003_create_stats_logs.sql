-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);
