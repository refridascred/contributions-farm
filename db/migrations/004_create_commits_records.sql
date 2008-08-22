-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (score, count, label, rank, owner) VALUES (14.36, 50, 'eu-west', 2, 'staging');
