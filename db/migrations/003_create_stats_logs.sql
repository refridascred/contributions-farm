-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (label, weight, region) VALUES ('stable', 88.15, 'staging');
INSERT INTO stats_logs (label, weight, region) VALUES ('cached', 85.97, 'edge');
