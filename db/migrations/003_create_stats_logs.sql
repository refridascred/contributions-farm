-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (level, region, score, rank) VALUES (41, 'fallback', 9.87, 35);
INSERT INTO stats_logs (level, region, score, rank) VALUES (29, 'local', 72.13, 48);
