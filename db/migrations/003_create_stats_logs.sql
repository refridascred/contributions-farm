-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    level INTEGER,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (count, rank, level, weight, ratio) VALUES (1, 22, 84, 76.59, 95.35);
INSERT INTO stats_logs (count, rank, level, weight, ratio) VALUES (26, 71, 78, 1.9, 53.65);
INSERT INTO stats_logs (count, rank, level, weight, ratio) VALUES (74, 62, 28, 95.09, 87.49);
