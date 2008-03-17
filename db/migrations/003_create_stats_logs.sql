-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (level, score, ratio, weight) VALUES (15, 88.96, 73.97, 17.53);
INSERT INTO stats_logs (level, score, ratio, weight) VALUES (63, 34.43, 16.52, 65.82);
INSERT INTO stats_logs (level, score, ratio, weight) VALUES (83, 53.83, 70.97, 96.28);
