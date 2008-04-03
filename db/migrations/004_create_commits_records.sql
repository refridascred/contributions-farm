-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (weight, rank) VALUES (75.29, 14);
INSERT INTO commits_records (weight, rank) VALUES (82.34, 11);
INSERT INTO commits_records (weight, rank) VALUES (51.09, 78);
