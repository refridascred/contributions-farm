-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (state, score, level, region, rank) VALUES ('local', 69.25, 38, 'latest', 19);
INSERT INTO stats_logs (state, score, level, region, rank) VALUES ('fallback', 64.14, 55, 'legacy', 6);
INSERT INTO stats_logs (state, score, level, region, rank) VALUES ('local', 50.58, 38, 'fallback', 42);
