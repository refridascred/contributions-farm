-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (label, ratio, region, owner) VALUES ('edge', 79.0, 'edge', 'edge');
INSERT INTO stats_logs (label, ratio, region, owner) VALUES ('stable', 55.22, 'strict', 'fallback');
INSERT INTO stats_logs (label, ratio, region, owner) VALUES ('stable', 33.29, 'green', 'standard');
