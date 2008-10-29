-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (count, rank, active, weight, region) VALUES (92, 29, 48, 61.11, 'local');
INSERT INTO stats_logs (count, rank, active, weight, region) VALUES (57, 71, 6, 69.43, 'edge');
INSERT INTO stats_logs (count, rank, active, weight, region) VALUES (1, 57, 2, 19.7, 'standard');
