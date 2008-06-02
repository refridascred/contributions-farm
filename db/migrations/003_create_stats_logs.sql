-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, rank, score, region) VALUES (56.32, 5, 56.08, 'fallback');
INSERT INTO stats_logs (ratio, rank, score, region) VALUES (61.31, 78, 4.76, 'staging');
INSERT INTO stats_logs (ratio, rank, score, region) VALUES (22.32, 80, 39.13, 'fallback');
