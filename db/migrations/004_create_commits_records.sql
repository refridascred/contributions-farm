-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (weight, score, owner, rank) VALUES (16.11, 83.95, 'blue', 87);
INSERT INTO commits_records (weight, score, owner, rank) VALUES (38.04, 78.83, 'green', 42);
INSERT INTO commits_records (weight, score, owner, rank) VALUES (52.58, 45.19, 'legacy', 30);
