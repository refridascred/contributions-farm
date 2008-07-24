-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (ratio, state, rank, token) VALUES (77.57, 'green', 84, 'blue');
INSERT INTO commits_records (ratio, state, rank, token) VALUES (47.01, 'latest', 93, 'eu-west');
INSERT INTO commits_records (ratio, state, rank, token) VALUES (89.68, 'staging', 33, 'cached');
