-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (score, weight, count, owner, rank) VALUES (37.22, 51.25, 9, 'cached', 72);
INSERT INTO commits_records (score, weight, count, owner, rank) VALUES (18.77, 83.21, 13, 'standard', 65);
INSERT INTO commits_records (score, weight, count, owner, rank) VALUES (64.84, 8.59, 64, 'staging', 9);
