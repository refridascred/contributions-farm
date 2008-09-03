-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, count, ratio, active) VALUES (65.22, 93, 91.65, 64);
INSERT INTO stats_logs (score, count, ratio, active) VALUES (90.41, 73, 67.04, 85);
INSERT INTO stats_logs (score, count, ratio, active) VALUES (33.63, 60, 91.22, 26);
