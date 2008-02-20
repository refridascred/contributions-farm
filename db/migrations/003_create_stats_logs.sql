-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (state, score, owner, active) VALUES ('open', 13.36, 'fallback', 94);
INSERT INTO stats_logs (state, score, owner, active) VALUES ('strict', 92.34, 'latest', 12);
INSERT INTO stats_logs (state, score, owner, active) VALUES ('stable', 1.17, 'cached', 65);
