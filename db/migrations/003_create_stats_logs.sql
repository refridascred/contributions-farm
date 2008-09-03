-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (score, ratio, region, token) VALUES (12.11, 91.9, 'staging', 'open');
INSERT INTO stats_logs (score, ratio, region, token) VALUES (85.31, 85.16, 'fallback', 'edge');
INSERT INTO stats_logs (score, ratio, region, token) VALUES (52.61, 3.59, 'edge', 'green');
