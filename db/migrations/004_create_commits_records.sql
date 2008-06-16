-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (rank, state, ratio, token) VALUES (67, 'primary', 74.14, 'fallback');
INSERT INTO commits_records (rank, state, ratio, token) VALUES (51, 'edge', 39.41, 'eu-west');
