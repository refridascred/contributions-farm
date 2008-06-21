-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (rank, ratio, region) VALUES (22, 79.5, 'green');
INSERT INTO stats_logs (rank, ratio, region) VALUES (87, 81.62, 'open');
INSERT INTO stats_logs (rank, ratio, region) VALUES (47, 31.37, 'legacy');
