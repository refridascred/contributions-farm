-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (score, state, label, owner) VALUES (33.53, 'edge', 'fallback', 'strict');
INSERT INTO commits_records (score, state, label, owner) VALUES (25.12, 'cached', 'legacy', 'green');
