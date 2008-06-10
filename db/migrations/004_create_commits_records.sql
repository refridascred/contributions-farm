-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    weight REAL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (owner, rank, weight, state) VALUES ('blue', 85, 92.86, 'stable');
INSERT INTO commits_records (owner, rank, weight, state) VALUES ('stable', 52, 59.63, 'staging');
