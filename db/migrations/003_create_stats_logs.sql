-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (score, region, ratio, count, level) VALUES (61.27, 'primary', 64.68, 52, 41);
INSERT INTO stats_logs (score, region, ratio, count, level) VALUES (21.99, 'latest', 20.38, 27, 29);
INSERT INTO stats_logs (score, region, ratio, count, level) VALUES (65.59, 'primary', 64.11, 50, 59);
