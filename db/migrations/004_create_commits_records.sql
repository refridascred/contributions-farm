-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, token) VALUES ('latest', 'primary');
INSERT INTO commits_records (state, token) VALUES ('staging', 'latest');
INSERT INTO commits_records (state, token) VALUES ('blue', 'eu-west');
