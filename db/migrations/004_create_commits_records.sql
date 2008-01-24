-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (count, rank, state) VALUES (22, 94, 'primary');
INSERT INTO commits_records (count, rank, state) VALUES (89, 84, 'latest');
INSERT INTO commits_records (count, rank, state) VALUES (59, 42, 'strict');
