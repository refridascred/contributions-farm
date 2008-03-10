-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (token, state, owner) VALUES ('blue', 'stable', 'staging');
INSERT INTO commits_records (token, state, owner) VALUES ('edge', 'edge', 'stable');
INSERT INTO commits_records (token, state, owner) VALUES ('standard', 'green', 'standard');
