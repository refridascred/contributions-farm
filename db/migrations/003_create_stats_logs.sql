-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (owner, level, score, region, count) VALUES ('fallback', 78, 93.08, 'primary', 14);
INSERT INTO stats_logs (owner, level, score, region, count) VALUES ('green', 81, 46.5, 'edge', 58);
INSERT INTO stats_logs (owner, level, score, region, count) VALUES ('green', 36, 75.77, 'staging', 21);
