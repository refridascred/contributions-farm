-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (weight, count, ratio, label) VALUES (82.73, 59, 50.15, 'primary');
INSERT INTO stats_logs (weight, count, ratio, label) VALUES (75.5, 74, 2.89, 'cached');
INSERT INTO stats_logs (weight, count, ratio, label) VALUES (76.24, 2, 75.21, 'open');
