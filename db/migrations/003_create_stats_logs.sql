-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (rank, count, region, level, score) VALUES (70, 95, 'stable', 58, 83.74);
INSERT INTO stats_logs (rank, count, region, level, score) VALUES (31, 63, 'blue', 56, 96.64);
INSERT INTO stats_logs (rank, count, region, level, score) VALUES (34, 18, 'latest', 98, 49.53);
