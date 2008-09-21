-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, rank, token) VALUES (74, 2, 'staging');
INSERT INTO commits_records (count, rank, token) VALUES (65, 21, 'edge');
INSERT INTO commits_records (count, rank, token) VALUES (58, 7, 'edge');
