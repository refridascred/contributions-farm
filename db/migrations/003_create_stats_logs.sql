-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (count, ratio, weight, label, owner) VALUES (43, 24.54, 69.21, 'legacy', 'green');
INSERT INTO stats_logs (count, ratio, weight, label, owner) VALUES (54, 88.24, 63.0, 'latest', 'eu-west');
INSERT INTO stats_logs (count, ratio, weight, label, owner) VALUES (5, 28.12, 87.35, 'open', 'edge');
