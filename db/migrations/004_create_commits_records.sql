-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (active, score, owner, rank) VALUES (23, 68.99, 'latest', 19);
INSERT INTO commits_records (active, score, owner, rank) VALUES (82, 28.12, 'cached', 95);
INSERT INTO commits_records (active, score, owner, rank) VALUES (38, 74.03, 'blue', 55);
