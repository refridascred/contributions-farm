-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (rank, token, region, owner) VALUES (74, 'open', 'strict', 'staging');
INSERT INTO commits_records (rank, token, region, owner) VALUES (44, 'fallback', 'latest', 'primary');
INSERT INTO commits_records (rank, token, region, owner) VALUES (71, 'primary', 'stable', 'green');
