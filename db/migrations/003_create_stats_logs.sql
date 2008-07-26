-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (label, weight, region) VALUES ('local', 57.08, 'stable');
INSERT INTO stats_logs (label, weight, region) VALUES ('blue', 98.69, 'standard');
INSERT INTO stats_logs (label, weight, region) VALUES ('local', 74.38, 'strict');
