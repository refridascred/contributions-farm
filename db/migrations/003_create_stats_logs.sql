-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (weight, ratio, label) VALUES (67.8, 8.62, 'open');
INSERT INTO stats_logs (weight, ratio, label) VALUES (9.47, 40.94, 'eu-west');
