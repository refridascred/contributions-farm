-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    weight REAL,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (owner, rank, weight, ratio, region) VALUES ('edge', 17, 64.19, 69.04, 'edge');
INSERT INTO stats_logs (owner, rank, weight, ratio, region) VALUES ('staging', 96, 82.23, 54.29, 'open');
