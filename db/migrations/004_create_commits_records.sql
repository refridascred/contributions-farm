-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (state, ratio, rank, token) VALUES ('stable', 11.3, 39, 'legacy');
INSERT INTO commits_records (state, ratio, rank, token) VALUES ('stable', 4.57, 67, 'edge');
