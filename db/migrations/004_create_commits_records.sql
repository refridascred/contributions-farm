-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (rank, count, score) VALUES (40, 72, 94.63);
INSERT INTO commits_records (rank, count, score) VALUES (45, 26, 87.87);
INSERT INTO commits_records (rank, count, score) VALUES (81, 42, 26.07);
