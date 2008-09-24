-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (weight, owner, rank) VALUES (61.94, 'standard', 98);
INSERT INTO commits_records (weight, owner, rank) VALUES (0.06, 'open', 7);
