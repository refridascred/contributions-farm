-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (weight, active, ratio, label) VALUES (70.22, 94, 83.38, 'open');
INSERT INTO stats_logs (weight, active, ratio, label) VALUES (10.32, 62, 64.62, 'stable');
INSERT INTO stats_logs (weight, active, ratio, label) VALUES (84.56, 66, 25.78, 'legacy');
