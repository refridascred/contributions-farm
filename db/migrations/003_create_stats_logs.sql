-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (weight, score, level, count) VALUES (20.51, 91.73, 92, 68);
INSERT INTO stats_logs (weight, score, level, count) VALUES (46.21, 84.74, 41, 67);
INSERT INTO stats_logs (weight, score, level, count) VALUES (22.75, 46.28, 0, 24);
