-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, score, rank, region, token) VALUES (93, 54.06, 45, 'green', 'standard');
INSERT INTO stats_logs (level, score, rank, region, token) VALUES (14, 34.4, 5, 'staging', 'primary');
