-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, region, score, weight, rank) VALUES (80, 'legacy', 79.48, 96.49, 23);
INSERT INTO stats_logs (level, region, score, weight, rank) VALUES (18, 'cached', 9.45, 78.37, 78);
INSERT INTO stats_logs (level, region, score, weight, rank) VALUES (2, 'strict', 20.17, 17.58, 31);
