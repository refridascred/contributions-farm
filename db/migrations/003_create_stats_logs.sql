-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (owner, ratio, active) VALUES ('edge', 45.54, 26);
INSERT INTO stats_logs (owner, ratio, active) VALUES ('open', 17.18, 42);
INSERT INTO stats_logs (owner, ratio, active) VALUES ('staging', 45.33, 5);
