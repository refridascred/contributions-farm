-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (owner, label, state, score) VALUES ('staging', 'local', 'edge', 14.19);
INSERT INTO commits_records (owner, label, state, score) VALUES ('local', 'edge', 'open', 77.97);
INSERT INTO commits_records (owner, label, state, score) VALUES ('standard', 'fallback', 'legacy', 48.71);
