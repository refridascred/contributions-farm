-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (level, state, score, count) VALUES (51, 'stable', 79.57, 96);
INSERT INTO stats_logs (level, state, score, count) VALUES (16, 'fallback', 67.61, 15);
INSERT INTO stats_logs (level, state, score, count) VALUES (73, 'legacy', 18.83, 80);
