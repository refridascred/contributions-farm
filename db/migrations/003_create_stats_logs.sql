-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    weight REAL,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (ratio, token, weight, label) VALUES (59.94, 'stable', 43.73, 'eu-west');
INSERT INTO stats_logs (ratio, token, weight, label) VALUES (91.6, 'stable', 33.45, 'standard');
INSERT INTO stats_logs (ratio, token, weight, label) VALUES (24.37, 'legacy', 65.36, 'primary');
