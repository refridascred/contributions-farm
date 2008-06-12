-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, level, score) VALUES (81.58, 5, 9.26);
INSERT INTO stats_logs (weight, level, score) VALUES (9.89, 87, 62.41);
INSERT INTO stats_logs (weight, level, score) VALUES (2.15, 84, 45.32);
