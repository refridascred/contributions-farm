-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (level, region, state, ratio) VALUES (64, 'legacy', 'stable', 1.15);
INSERT INTO stats_logs (level, region, state, ratio) VALUES (28, 'latest', 'green', 34.74);
INSERT INTO stats_logs (level, region, state, ratio) VALUES (5, 'legacy', 'latest', 57.73);
