-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    ratio REAL,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (weight, region, ratio, label, owner) VALUES (91.29, 'latest', 91.26, 'latest', 'edge');
INSERT INTO stats_logs (weight, region, ratio, label, owner) VALUES (6.05, 'eu-west', 54.2, 'standard', 'stable');
