-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (level, state, score, token, active) VALUES (53, 'fallback', 31.1, 'legacy', 29);
INSERT INTO commits_records (level, state, score, token, active) VALUES (1, 'fallback', 72.43, 'green', 61);
