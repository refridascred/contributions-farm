-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (owner, active, state, token, score) VALUES ('green', 36, 'local', 'eu-west', 0.65);
INSERT INTO stats_logs (owner, active, state, token, score) VALUES ('standard', 67, 'legacy', 'cached', 83.3);
