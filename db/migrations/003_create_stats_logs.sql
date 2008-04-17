-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (label, score, count, state) VALUES ('edge', 42.44, 1, 'fallback');
INSERT INTO stats_logs (label, score, count, state) VALUES ('blue', 19.37, 64, 'open');
INSERT INTO stats_logs (label, score, count, state) VALUES ('blue', 19.11, 22, 'legacy');
