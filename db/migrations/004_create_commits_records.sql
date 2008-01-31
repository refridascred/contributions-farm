-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, label, count, level) VALUES (44, 'staging', 99, 62);
