-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (state, token, score, level, owner) VALUES ('legacy', 'green', 58.85, 36, 'strict');
INSERT INTO commits_records (state, token, score, level, owner) VALUES ('open', 'fallback', 39.47, 70, 'blue');
