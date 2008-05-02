-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (level, weight, count) VALUES (2, 93.09, 49);
INSERT INTO stats_logs (level, weight, count) VALUES (26, 22.88, 50);
INSERT INTO stats_logs (level, weight, count) VALUES (3, 79.0, 75);
