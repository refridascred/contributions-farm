-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (weight, region, label) VALUES (63.86, 'standard', 'local');
INSERT INTO stats_logs (weight, region, label) VALUES (45.28, 'primary', 'open');
INSERT INTO stats_logs (weight, region, label) VALUES (89.62, 'green', 'stable');
