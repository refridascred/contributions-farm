-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (owner, token, count) VALUES ('local', 'local', 14);
INSERT INTO commits_records (owner, token, count) VALUES ('fallback', 'standard', 3);
INSERT INTO commits_records (owner, token, count) VALUES ('fallback', 'legacy', 28);
