-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (region, weight, active, token) VALUES ('open', 16.66, 9, 'stable');
INSERT INTO stats_logs (region, weight, active, token) VALUES ('latest', 68.81, 50, 'latest');
INSERT INTO stats_logs (region, weight, active, token) VALUES ('strict', 19.75, 83, 'stable');
