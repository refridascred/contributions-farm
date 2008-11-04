-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (count, ratio, label, region) VALUES (97, 40.26, 'primary', 'edge');
INSERT INTO stats_logs (count, ratio, label, region) VALUES (39, 64.04, 'eu-west', 'latest');
