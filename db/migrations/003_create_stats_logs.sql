-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (region, score, level, weight, count) VALUES ('green', 50.09, 4, 38.67, 74);
INSERT INTO stats_logs (region, score, level, weight, count) VALUES ('stable', 46.26, 45, 64.31, 31);
INSERT INTO stats_logs (region, score, level, weight, count) VALUES ('legacy', 50.16, 22, 57.92, 51);
