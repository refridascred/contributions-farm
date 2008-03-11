-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (ratio, count, weight) VALUES (24.6, 30, 21.15);
INSERT INTO stats_logs (ratio, count, weight) VALUES (41.39, 5, 71.56);
INSERT INTO stats_logs (ratio, count, weight) VALUES (51.43, 68, 33.84);
