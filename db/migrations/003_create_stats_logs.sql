-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (ratio, label, region) VALUES (33.68, 'blue', 'open');
INSERT INTO stats_logs (ratio, label, region) VALUES (39.78, 'standard', 'legacy');
