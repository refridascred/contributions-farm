-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (owner, token, count, active) VALUES ('green', 'legacy', 42, 23);
INSERT INTO stats_logs (owner, token, count, active) VALUES ('blue', 'edge', 85, 89);
INSERT INTO stats_logs (owner, token, count, active) VALUES ('staging', 'standard', 31, 93);
