-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (label, owner, state, token, rank) VALUES ('blue', 'staging', 'local', 'edge', 67);
INSERT INTO commits_records (label, owner, state, token, rank) VALUES ('local', 'cached', 'legacy', 'open', 94);
