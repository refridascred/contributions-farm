-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (rank, ratio, region) VALUES (51, 85.22, 'staging');
INSERT INTO stats_logs (rank, ratio, region) VALUES (36, 55.0, 'primary');
INSERT INTO stats_logs (rank, ratio, region) VALUES (35, 8.07, 'edge');
