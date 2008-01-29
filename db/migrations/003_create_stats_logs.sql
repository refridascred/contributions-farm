-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (weight, label) VALUES (33.56, 'stable');
INSERT INTO stats_logs (weight, label) VALUES (98.04, 'eu-west');
INSERT INTO stats_logs (weight, label) VALUES (70.74, 'standard');
