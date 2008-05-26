-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (state, token) VALUES ('cached', 'strict');
INSERT INTO commits_records (state, token) VALUES ('stable', 'green');
INSERT INTO commits_records (state, token) VALUES ('local', 'strict');
