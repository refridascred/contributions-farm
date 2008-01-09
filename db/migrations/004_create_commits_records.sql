-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    rank INTEGER,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (ratio, owner, rank, token, label) VALUES (5.42, 'green', 84, 'edge', 'staging');
INSERT INTO commits_records (ratio, owner, rank, token, label) VALUES (60.82, 'staging', 10, 'staging', 'green');
