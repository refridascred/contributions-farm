-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (rank, count, score, region, level) VALUES (92, 74, 32.16, 'eu-west', 60);
INSERT INTO stats_logs (rank, count, score, region, level) VALUES (18, 83, 43.88, 'staging', 0);
