-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, ratio, region, token) VALUES (85, 82.9, 'eu-west', 'primary');
INSERT INTO commits_records (rank, ratio, region, token) VALUES (86, 73.74, 'staging', 'local');
