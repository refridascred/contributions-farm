-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, token, state) VALUES (64, 'standard', 'blue');
INSERT INTO commits_records (rank, token, state) VALUES (19, 'blue', 'primary');
INSERT INTO commits_records (rank, token, state) VALUES (64, 'legacy', 'legacy');
