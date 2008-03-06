-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (region, count, owner, rank, token) VALUES ('open', 62, 'staging', 47, 'strict');
INSERT INTO commits_records (region, count, owner, rank, token) VALUES ('legacy', 35, 'latest', 5, 'green');
