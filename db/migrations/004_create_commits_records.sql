-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (count, token) VALUES (12, 'latest');
INSERT INTO commits_records (count, token) VALUES (21, 'stable');
INSERT INTO commits_records (count, token) VALUES (38, 'stable');
