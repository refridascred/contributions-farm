-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (level, rank, label) VALUES (5, 34, 'open');
