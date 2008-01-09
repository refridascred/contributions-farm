-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (rank, token, owner) VALUES (30, 'staging', 'fallback');
INSERT INTO commits_records (rank, token, owner) VALUES (6, 'fallback', 'open');
INSERT INTO commits_records (rank, token, owner) VALUES (49, 'green', 'cached');
