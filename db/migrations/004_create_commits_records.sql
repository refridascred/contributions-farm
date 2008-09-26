-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (weight, owner, state, token) VALUES (51.84, 'fallback', 'stable', 'edge');
INSERT INTO commits_records (weight, owner, state, token) VALUES (14.53, 'green', 'legacy', 'cached');
