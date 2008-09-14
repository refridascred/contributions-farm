-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (count, score, rank) VALUES (55, 65.58, 55);
INSERT INTO commits_records (count, score, rank) VALUES (51, 43.46, 54);
INSERT INTO commits_records (count, score, rank) VALUES (82, 44.23, 73);
