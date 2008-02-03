-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (level, rank, score, weight, count) VALUES (16, 61, 2.51, 40.75, 86);
INSERT INTO stats_logs (level, rank, score, weight, count) VALUES (73, 54, 86.0, 24.08, 77);
