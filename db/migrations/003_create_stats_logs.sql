-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (active, weight, token) VALUES (63, 72.34, 'edge');
INSERT INTO stats_logs (active, weight, token) VALUES (32, 71.87, 'local');
INSERT INTO stats_logs (active, weight, token) VALUES (14, 62.05, 'cached');
