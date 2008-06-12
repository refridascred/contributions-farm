-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    rank INTEGER,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (ratio, owner, rank, token, count) VALUES (83.18, 'fallback', 4, 'eu-west', 53);
INSERT INTO commits_records (ratio, owner, rank, token, count) VALUES (85.71, 'stable', 98, 'fallback', 51);
