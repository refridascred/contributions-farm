-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (active, count, rank, owner, label) VALUES (43, 80, 69, 'staging', 'green');
INSERT INTO commits_records (active, count, rank, owner, label) VALUES (58, 3, 14, 'stable', 'fallback');
