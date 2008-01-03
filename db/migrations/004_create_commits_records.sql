-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, count, label) VALUES (7, 16, 'local');
INSERT INTO commits_records (rank, count, label) VALUES (80, 75, 'staging');
INSERT INTO commits_records (rank, count, label) VALUES (38, 8, 'latest');
