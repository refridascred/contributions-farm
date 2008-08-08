-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (state, count, region, level, weight) VALUES ('green', 93, 'latest', 38, 85.47);
INSERT INTO stats_logs (state, count, region, level, weight) VALUES ('fallback', 32, 'staging', 28, 83.41);
INSERT INTO stats_logs (state, count, region, level, weight) VALUES ('green', 93, 'legacy', 96, 43.44);
