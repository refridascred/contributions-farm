-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    created_at TIMESTAMP,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (score, token, rank, weight) VALUES (70.14, 'standard', 30, 9.46);
INSERT INTO commits_records (score, token, rank, weight) VALUES (82.33, 'open', 38, 81.47);
