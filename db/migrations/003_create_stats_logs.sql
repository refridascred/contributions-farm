-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (label, ratio, region, rank) VALUES ('standard', 85.11, 'standard', 18);
INSERT INTO stats_logs (label, ratio, region, rank) VALUES ('legacy', 49.2, 'standard', 50);
