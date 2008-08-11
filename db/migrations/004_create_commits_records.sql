-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (rank, region, token) VALUES (81, 'green', 'eu-west');
INSERT INTO commits_records (rank, region, token) VALUES (58, 'primary', 'standard');
