-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    owner TEXT NOT NULL,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, owner, rank, ratio) VALUES ('open', 'cached', 49, 58.32);
INSERT INTO commits_records (token, owner, rank, ratio) VALUES ('eu-west', 'edge', 39, 17.21);
