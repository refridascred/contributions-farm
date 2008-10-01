-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (count, score, ratio) VALUES (58, 47.72, 86.78);
INSERT INTO commits_records (count, score, ratio) VALUES (79, 34.83, 55.96);
INSERT INTO commits_records (count, score, ratio) VALUES (88, 39.45, 87.27);
