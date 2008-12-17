-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, level, label) VALUES (69.14, 1, 'primary');
INSERT INTO stats_logs (weight, level, label) VALUES (29.2, 8, 'edge');
INSERT INTO stats_logs (weight, level, label) VALUES (33.7, 98, 'local');
