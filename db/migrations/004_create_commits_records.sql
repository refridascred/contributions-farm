-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (active, rank, weight) VALUES (18, 25, 91.9);
INSERT INTO commits_records (active, rank, weight) VALUES (18, 8, 88.12);
INSERT INTO commits_records (active, rank, weight) VALUES (20, 36, 67.8);
