-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (count, rank, score) VALUES (12, 95, 72.32);
INSERT INTO commits_records (count, rank, score) VALUES (77, 69, 39.8);
INSERT INTO commits_records (count, rank, score) VALUES (79, 39, 96.68);
