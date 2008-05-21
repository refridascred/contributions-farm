-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (weight, rank, region) VALUES (47.63, 84, 'green');
INSERT INTO stats_logs (weight, rank, region) VALUES (86.83, 72, 'legacy');
