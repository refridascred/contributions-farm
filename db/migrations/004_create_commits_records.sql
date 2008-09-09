-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (region, rank, token) VALUES ('stable', 80, 'primary');
INSERT INTO commits_records (region, rank, token) VALUES ('green', 88, 'latest');
INSERT INTO commits_records (region, rank, token) VALUES ('strict', 44, 'edge');
