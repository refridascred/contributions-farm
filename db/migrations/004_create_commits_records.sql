-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, state, token) VALUES (76, 'eu-west', 'primary');
INSERT INTO commits_records (rank, state, token) VALUES (67, 'legacy', 'green');
INSERT INTO commits_records (rank, state, token) VALUES (48, 'legacy', 'cached');
