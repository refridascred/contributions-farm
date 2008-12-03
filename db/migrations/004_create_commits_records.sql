-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, owner, weight) VALUES (8, 'primary', 47.9);
INSERT INTO commits_records (rank, owner, weight) VALUES (45, 'primary', 30.27);
INSERT INTO commits_records (rank, owner, weight) VALUES (35, 'standard', 88.19);
