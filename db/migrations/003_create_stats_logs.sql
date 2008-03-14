-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (score, region, ratio, active) VALUES (65.24, 'eu-west', 91.18, 26);
INSERT INTO stats_logs (score, region, ratio, active) VALUES (67.16, 'blue', 80.51, 77);
INSERT INTO stats_logs (score, region, ratio, active) VALUES (6.73, 'standard', 52.58, 10);
