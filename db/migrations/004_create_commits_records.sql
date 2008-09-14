-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, owner) VALUES (35, 'blue');
INSERT INTO commits_records (rank, owner) VALUES (27, 'edge');
INSERT INTO commits_records (rank, owner) VALUES (0, 'legacy');
