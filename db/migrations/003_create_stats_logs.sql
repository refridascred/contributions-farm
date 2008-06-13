-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    region TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, level, region, ratio, count) VALUES (76.65, 0, 'latest', 45.94, 40);
INSERT INTO stats_logs (score, level, region, ratio, count) VALUES (40.82, 26, 'blue', 12.88, 35);
