-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, count, active) VALUES (33, 88, 29);
INSERT INTO commits_records (rank, count, active) VALUES (79, 92, 54);
INSERT INTO commits_records (rank, count, active) VALUES (4, 48, 41);
