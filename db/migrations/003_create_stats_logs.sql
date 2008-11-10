-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, region, state) VALUES (34.51, 'eu-west', 'latest');
INSERT INTO stats_logs (weight, region, state) VALUES (10.4, 'eu-west', 'latest');
INSERT INTO stats_logs (weight, region, state) VALUES (67.43, 'standard', 'strict');
