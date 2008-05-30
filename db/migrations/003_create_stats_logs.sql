-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (active, weight, region) VALUES (27, 68.7, 'staging');
INSERT INTO stats_logs (active, weight, region) VALUES (72, 44.1, 'open');
INSERT INTO stats_logs (active, weight, region) VALUES (14, 34.06, 'stable');
