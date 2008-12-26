-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (weight, ratio, label, score) VALUES (68.04, 61.63, 'green', 63.35);
INSERT INTO stats_logs (weight, ratio, label, score) VALUES (8.47, 53.58, 'edge', 42.02);
