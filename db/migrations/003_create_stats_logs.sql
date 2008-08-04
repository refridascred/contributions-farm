-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, ratio, label) VALUES (68, 12.32, 'standard');
INSERT INTO stats_logs (count, ratio, label) VALUES (42, 33.57, 'open');
INSERT INTO stats_logs (count, ratio, label) VALUES (9, 36.13, 'staging');
