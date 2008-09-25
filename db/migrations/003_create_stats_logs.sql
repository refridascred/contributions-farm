-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (score, active, ratio, owner) VALUES (9.16, 47, 95.6, 'legacy');
INSERT INTO stats_logs (score, active, ratio, owner) VALUES (49.36, 89, 85.76, 'cached');
INSERT INTO stats_logs (score, active, ratio, owner) VALUES (32.36, 42, 28.81, 'latest');
