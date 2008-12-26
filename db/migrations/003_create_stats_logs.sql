-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (weight, count, region, rank, token) VALUES (43.66, 47, 'staging', 53, 'eu-west');
INSERT INTO stats_logs (weight, count, region, rank, token) VALUES (42.83, 95, 'green', 95, 'primary');
INSERT INTO stats_logs (weight, count, region, rank, token) VALUES (39.39, 41, 'strict', 30, 'blue');
