-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (ratio, score, rank) VALUES (10.22, 62.14, 62);
INSERT INTO commits_records (ratio, score, rank) VALUES (80.9, 68.11, 13);
INSERT INTO commits_records (ratio, score, rank) VALUES (55.45, 59.88, 43);
