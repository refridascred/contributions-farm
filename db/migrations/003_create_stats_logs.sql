-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, active, count, label) VALUES (65.06, 34, 69, 'strict');
INSERT INTO stats_logs (weight, active, count, label) VALUES (60.81, 78, 90, 'eu-west');
INSERT INTO stats_logs (weight, active, count, label) VALUES (82.97, 94, 42, 'legacy');
