-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (count, score, weight, ratio) VALUES (27, 81.91, 41.16, 56.99);
INSERT INTO commits_records (count, score, weight, ratio) VALUES (35, 79.7, 87.17, 66.1);
