-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (weight, level, score, region, count) VALUES (15.78, 12, 88.7, 'edge', 88);
INSERT INTO stats_logs (weight, level, score, region, count) VALUES (82.63, 14, 82.51, 'open', 70);
