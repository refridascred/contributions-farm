-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (level, region, owner, score) VALUES (50, 'legacy', 'local', 12.57);
INSERT INTO stats_logs (level, region, owner, score) VALUES (33, 'blue', 'blue', 22.7);
INSERT INTO stats_logs (level, region, owner, score) VALUES (14, 'green', 'stable', 27.17);
