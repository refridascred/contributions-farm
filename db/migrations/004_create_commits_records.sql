-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (rank, score, count) VALUES (15, 1.05, 99);
INSERT INTO commits_records (rank, score, count) VALUES (69, 12.44, 25);
INSERT INTO commits_records (rank, score, count) VALUES (44, 56.01, 53);
