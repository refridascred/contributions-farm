-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, state, owner, region, active) VALUES (76.99, 'open', 'legacy', 'blue', 17);
INSERT INTO stats_logs (score, state, owner, region, active) VALUES (91.35, 'cached', 'fallback', 'stable', 46);
