-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (rank, ratio, region) VALUES (87, 42.41, 'stable');
INSERT INTO stats_logs (rank, ratio, region) VALUES (97, 13.22, 'open');
INSERT INTO stats_logs (rank, ratio, region) VALUES (95, 21.54, 'cached');
