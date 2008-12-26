-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    token TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (owner, ratio, token, label, active) VALUES ('edge', 18.3, 'cached', 'staging', 6);
INSERT INTO stats_logs (owner, ratio, token, label, active) VALUES ('green', 1.33, 'edge', 'blue', 86);
