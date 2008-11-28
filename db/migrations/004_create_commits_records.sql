-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, rank, label) VALUES (70, 9, 'blue');
INSERT INTO commits_records (count, rank, label) VALUES (5, 42, 'eu-west');
INSERT INTO commits_records (count, rank, label) VALUES (13, 75, 'strict');
