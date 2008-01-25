-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, token, level, active) VALUES (58, 'legacy', 27, 21);
INSERT INTO commits_records (rank, token, level, active) VALUES (0, 'green', 92, 9);
INSERT INTO commits_records (rank, token, level, active) VALUES (79, 'edge', 68, 55);
