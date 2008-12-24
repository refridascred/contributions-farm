-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (owner, state, level, score, token) VALUES ('staging', 'fallback', 6, 47.67, 'primary');
INSERT INTO commits_records (owner, state, level, score, token) VALUES ('legacy', 'standard', 33, 66.98, 'cached');
