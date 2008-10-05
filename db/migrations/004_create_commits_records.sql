-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (state, owner, token) VALUES ('legacy', 'edge', 'staging');
INSERT INTO commits_records (state, owner, token) VALUES ('latest', 'edge', 'blue');
INSERT INTO commits_records (state, owner, token) VALUES ('legacy', 'latest', 'open');
