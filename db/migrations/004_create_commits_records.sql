-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, region, rank, token) VALUES (27, 'open', 77, 'latest');
INSERT INTO commits_records (count, region, rank, token) VALUES (5, 'staging', 18, 'edge');
INSERT INTO commits_records (count, region, rank, token) VALUES (40, 'cached', 1, 'standard');
