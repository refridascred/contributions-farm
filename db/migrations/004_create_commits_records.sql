-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (active, rank, count) VALUES (84, 48, 47);
INSERT INTO commits_records (active, rank, count) VALUES (27, 10, 56);
INSERT INTO commits_records (active, rank, count) VALUES (0, 90, 65);
