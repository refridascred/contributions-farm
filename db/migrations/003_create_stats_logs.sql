-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (ratio, score, region) VALUES (72.78, 6.34, 'standard');
INSERT INTO stats_logs (ratio, score, region) VALUES (58.58, 32.43, 'staging');
INSERT INTO stats_logs (ratio, score, region) VALUES (22.65, 29.31, 'local');
