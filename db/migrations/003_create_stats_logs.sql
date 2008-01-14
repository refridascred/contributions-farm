-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    created_at TIMESTAMP,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, region, ratio, rank) VALUES (59.31, 'stable', 34.9, 97);
