-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (count, score, ratio, weight, label) VALUES (99, 53.02, 81.3, 97.83, 'green');
INSERT INTO stats_logs (count, score, ratio, weight, label) VALUES (20, 90.07, 74.94, 83.62, 'staging');
