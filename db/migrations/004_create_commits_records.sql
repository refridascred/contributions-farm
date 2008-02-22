-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, state, rank) VALUES ('primary', 'cached', 11);
INSERT INTO commits_records (token, state, rank) VALUES ('standard', 'eu-west', 25);
INSERT INTO commits_records (token, state, rank) VALUES ('green', 'local', 45);
