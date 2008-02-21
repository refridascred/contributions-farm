-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (weight, label, active) VALUES (50.7, 'latest', 51);
INSERT INTO stats_logs (weight, label, active) VALUES (16.43, 'edge', 36);
INSERT INTO stats_logs (weight, label, active) VALUES (30.82, 'primary', 6);
