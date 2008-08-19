-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    level INTEGER,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (score, region, level, rank, token) VALUES (74.82, 'latest', 2, 15, 'edge');
INSERT INTO stats_logs (score, region, level, rank, token) VALUES (9.03, 'fallback', 62, 98, 'standard');
INSERT INTO stats_logs (score, region, level, rank, token) VALUES (42.3, 'staging', 3, 61, 'staging');
