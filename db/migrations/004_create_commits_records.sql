-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (rank, region, token) VALUES (32, 'stable', 'latest');
INSERT INTO commits_records (rank, region, token) VALUES (20, 'legacy', 'legacy');
INSERT INTO commits_records (rank, region, token) VALUES (75, 'open', 'edge');
