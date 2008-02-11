-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    token TEXT,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (ratio, token, owner, region) VALUES (83.09, 'local', 'local', 'staging');
INSERT INTO commits_records (ratio, token, owner, region) VALUES (74.61, 'legacy', 'local', 'green');
