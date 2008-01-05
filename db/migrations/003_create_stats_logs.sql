-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    ratio REAL,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (token, ratio, owner, count) VALUES ('standard', 4.29, 'local', 83);
INSERT INTO stats_logs (token, ratio, owner, count) VALUES ('edge', 45.16, 'standard', 52);
