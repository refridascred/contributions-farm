-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, owner, ratio, active) VALUES ('standard', 'latest', 49.28, 89);
INSERT INTO stats_logs (token, owner, ratio, active) VALUES ('edge', 'primary', 16.4, 95);
