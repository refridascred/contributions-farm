-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (count, weight, active, region) VALUES (7, 0.11, 71, 'open');
INSERT INTO stats_logs (count, weight, active, region) VALUES (24, 32.04, 50, 'standard');
INSERT INTO stats_logs (count, weight, active, region) VALUES (67, 76.37, 74, 'open');
