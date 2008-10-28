-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (weight, level, score, rank) VALUES (15.46, 34, 7.46, 40);
INSERT INTO stats_logs (weight, level, score, rank) VALUES (0.82, 20, 91.61, 4);
INSERT INTO stats_logs (weight, level, score, rank) VALUES (49.99, 51, 20.27, 47);
