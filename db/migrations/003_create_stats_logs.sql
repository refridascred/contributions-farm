-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    rank INTEGER,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (ratio, region, rank, label, weight) VALUES (98.5, 'blue', 51, 'open', 6.42);
INSERT INTO stats_logs (ratio, region, rank, label, weight) VALUES (92.64, 'green', 58, 'open', 2.24);
INSERT INTO stats_logs (ratio, region, rank, label, weight) VALUES (42.69, 'latest', 46, 'legacy', 51.4);
