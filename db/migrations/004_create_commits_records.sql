-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (rank, region, count, token) VALUES (60, 'stable', 14, 'open');
INSERT INTO commits_records (rank, region, count, token) VALUES (45, 'green', 17, 'fallback');
INSERT INTO commits_records (rank, region, count, token) VALUES (82, 'blue', 20, 'strict');
