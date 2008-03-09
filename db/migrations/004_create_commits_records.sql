-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (rank, region) VALUES (27, 'latest');
INSERT INTO commits_records (rank, region) VALUES (12, 'legacy');
INSERT INTO commits_records (rank, region) VALUES (80, 'eu-west');
