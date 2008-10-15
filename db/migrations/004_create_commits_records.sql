-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, region, owner) VALUES (92, 'standard', 'latest');
INSERT INTO commits_records (count, region, owner) VALUES (28, 'open', 'edge');
INSERT INTO commits_records (count, region, owner) VALUES (61, 'latest', 'staging');
