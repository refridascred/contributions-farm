-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (rank, score, count) VALUES (98, 18.52, 53);
INSERT INTO commits_records (rank, score, count) VALUES (15, 56.43, 60);
INSERT INTO commits_records (rank, score, count) VALUES (43, 21.85, 2);
