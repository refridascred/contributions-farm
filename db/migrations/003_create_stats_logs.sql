-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (count, weight, owner) VALUES (23, 49.06, 'cached');
INSERT INTO stats_logs (count, weight, owner) VALUES (10, 40.7, 'latest');
INSERT INTO stats_logs (count, weight, owner) VALUES (11, 52.7, 'cached');
