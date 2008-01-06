-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (token, owner) VALUES ('primary', 'standard');
INSERT INTO commits_records (token, owner) VALUES ('stable', 'fallback');
INSERT INTO commits_records (token, owner) VALUES ('latest', 'strict');
