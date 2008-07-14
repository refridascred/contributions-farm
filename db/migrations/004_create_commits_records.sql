-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (weight, active, rank) VALUES (16.17, 68, 61);
INSERT INTO commits_records (weight, active, rank) VALUES (19.11, 82, 92);
INSERT INTO commits_records (weight, active, rank) VALUES (64.49, 5, 58);
