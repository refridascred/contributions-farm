-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (weight, ratio, label, count) VALUES (42.36, 19.08, 'standard', 64);
INSERT INTO stats_logs (weight, ratio, label, count) VALUES (21.27, 81.23, 'staging', 63);
