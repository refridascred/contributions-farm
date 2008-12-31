-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (rank, count, token, label) VALUES (23, 43, 'fallback', 'latest');
INSERT INTO commits_records (rank, count, token, label) VALUES (34, 79, 'edge', 'stable');
INSERT INTO commits_records (rank, count, token, label) VALUES (90, 35, 'edge', 'standard');
