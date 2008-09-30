-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (token, count, owner, ratio) VALUES ('edge', 59, 'local', 16.34);
INSERT INTO commits_records (token, count, owner, ratio) VALUES ('blue', 27, 'local', 16.14);
INSERT INTO commits_records (token, count, owner, ratio) VALUES ('open', 61, 'primary', 98.46);
