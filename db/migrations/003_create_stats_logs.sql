-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (weight, active, label) VALUES (17.31, 93, 'stable');
INSERT INTO stats_logs (weight, active, label) VALUES (96.4, 29, 'green');
INSERT INTO stats_logs (weight, active, label) VALUES (5.79, 61, 'cached');
