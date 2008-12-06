-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (count, score, rank) VALUES (37, 16.6, 32);
INSERT INTO commits_records (count, score, rank) VALUES (66, 37.4, 39);
INSERT INTO commits_records (count, score, rank) VALUES (10, 88.51, 45);
