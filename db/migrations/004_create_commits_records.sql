-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, owner, level) VALUES ('open', 'fallback', 13);
INSERT INTO commits_records (token, owner, level) VALUES ('standard', 'green', 62);
