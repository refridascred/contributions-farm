-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, state, rank, count) VALUES (39.21, 'staging', 46, 41);
INSERT INTO stats_logs (score, state, rank, count) VALUES (17.85, 'open', 3, 39);
INSERT INTO stats_logs (score, state, rank, count) VALUES (14.35, 'edge', 72, 62);
