-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (token, state, owner, rank) VALUES ('strict', 'legacy', 'strict', 91);
INSERT INTO commits_records (token, state, owner, rank) VALUES ('edge', 'local', 'green', 38);
