-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, ratio, owner) VALUES ('edge', 37.1, 'latest');
INSERT INTO commits_records (token, ratio, owner) VALUES ('local', 88.7, 'local');
