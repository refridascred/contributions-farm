-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (ratio, label, weight) VALUES (90.54, 'stable', 83.6);
INSERT INTO stats_logs (ratio, label, weight) VALUES (29.49, 'standard', 53.45);
