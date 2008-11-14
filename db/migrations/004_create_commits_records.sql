-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, token, owner) VALUES ('latest', 'legacy', 'local');
INSERT INTO commits_records (state, token, owner) VALUES ('primary', 'stable', 'staging');
INSERT INTO commits_records (state, token, owner) VALUES ('latest', 'latest', 'stable');
