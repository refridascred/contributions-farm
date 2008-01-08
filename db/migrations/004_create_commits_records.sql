-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (weight, score, count, token, owner) VALUES (40.88, 26.88, 1, 'standard', 'fallback');
INSERT INTO commits_records (weight, score, count, token, owner) VALUES (62.23, 50.74, 30, 'strict', 'strict');
INSERT INTO commits_records (weight, score, count, token, owner) VALUES (17.15, 68.46, 24, 'blue', 'green');
