-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (active, rank) VALUES (31, 14);
INSERT INTO commits_records (active, rank) VALUES (82, 43);
INSERT INTO commits_records (active, rank) VALUES (68, 57);
