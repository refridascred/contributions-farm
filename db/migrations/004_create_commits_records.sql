-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (score, owner, rank, label) VALUES (1.67, 'cached', 93, 'strict');
INSERT INTO commits_records (score, owner, rank, label) VALUES (41.5, 'strict', 5, 'staging');
