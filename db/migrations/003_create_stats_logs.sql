-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (token, level, weight, score) VALUES ('open', 68, 55.77, 61.32);
INSERT INTO stats_logs (token, level, weight, score) VALUES ('blue', 67, 78.52, 34.0);
INSERT INTO stats_logs (token, level, weight, score) VALUES ('edge', 27, 80.1, 83.02);
