-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (active, weight, rank, region) VALUES (87, 6.35, 91, 'blue');
INSERT INTO stats_logs (active, weight, rank, region) VALUES (62, 16.28, 71, 'stable');
INSERT INTO stats_logs (active, weight, rank, region) VALUES (59, 65.74, 96, 'eu-west');
