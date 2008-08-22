-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, rank, ratio, region) VALUES (38.26, 52, 46.16, 'primary');
INSERT INTO stats_logs (score, rank, ratio, region) VALUES (42.56, 83, 39.56, 'latest');
