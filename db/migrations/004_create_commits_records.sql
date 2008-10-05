-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (score, rank, weight) VALUES (44.73, 18, 77.84);
INSERT INTO commits_records (score, rank, weight) VALUES (35.65, 91, 69.36);
INSERT INTO commits_records (score, rank, weight) VALUES (26.36, 56, 92.73);
