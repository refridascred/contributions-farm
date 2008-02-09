-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, region, rank) VALUES (42.31, 'green', 48);
INSERT INTO stats_logs (ratio, region, rank) VALUES (96.19, 'fallback', 35);
INSERT INTO stats_logs (ratio, region, rank) VALUES (64.09, 'cached', 37);
