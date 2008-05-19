-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    level INTEGER,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, rank, level, ratio, count) VALUES (13.66, 15, 47, 82.82, 37);
INSERT INTO stats_logs (weight, rank, level, ratio, count) VALUES (63.4, 31, 10, 2.76, 83);
INSERT INTO stats_logs (weight, rank, level, ratio, count) VALUES (60.9, 64, 32, 18.22, 44);
