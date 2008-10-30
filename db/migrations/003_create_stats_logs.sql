-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (count, ratio, label, active) VALUES (90, 33.87, 'eu-west', 8);
INSERT INTO stats_logs (count, ratio, label, active) VALUES (5, 95.36, 'edge', 38);
