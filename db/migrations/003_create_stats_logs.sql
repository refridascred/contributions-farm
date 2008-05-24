-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (rank, weight, region, level) VALUES (58, 94.13, 'latest', 11);
INSERT INTO stats_logs (rank, weight, region, level) VALUES (69, 85.48, 'blue', 59);
INSERT INTO stats_logs (rank, weight, region, level) VALUES (71, 92.14, 'fallback', 59);
