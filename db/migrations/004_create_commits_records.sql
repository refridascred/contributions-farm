-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (score, owner, rank) VALUES (86.64, 'green', 97);
INSERT INTO commits_records (score, owner, rank) VALUES (20.9, 'open', 13);
INSERT INTO commits_records (score, owner, rank) VALUES (34.35, 'staging', 33);
