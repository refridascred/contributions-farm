-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    ratio REAL,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (token, owner, ratio, rank) VALUES ('legacy', 'cached', 75.74, 32);
INSERT INTO commits_records (token, owner, ratio, rank) VALUES ('eu-west', 'legacy', 72.05, 50);
