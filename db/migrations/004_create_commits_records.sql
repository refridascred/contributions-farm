-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (count, rank, label) VALUES (54, 49, 'open');
INSERT INTO commits_records (count, rank, label) VALUES (11, 53, 'legacy');
INSERT INTO commits_records (count, rank, label) VALUES (73, 50, 'strict');
