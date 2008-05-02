-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (count, state, label, token) VALUES (97, 'legacy', 'strict', 'strict');
INSERT INTO commits_records (count, state, label, token) VALUES (26, 'edge', 'edge', 'staging');
