-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (ratio, owner, score) VALUES (3.47, 'staging', 14.97);
INSERT INTO commits_records (ratio, owner, score) VALUES (55.5, 'open', 81.9);
INSERT INTO commits_records (ratio, owner, score) VALUES (4.03, 'edge', 98.35);
