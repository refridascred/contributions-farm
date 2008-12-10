-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (region, score, state, count, ratio) VALUES ('standard', 47.81, 'latest', 59, 47.71);
INSERT INTO stats_logs (region, score, state, count, ratio) VALUES ('green', 22.98, 'legacy', 31, 45.2);
