-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (owner, rank, region) VALUES ('fallback', 22, 'green');
INSERT INTO commits_records (owner, rank, region) VALUES ('eu-west', 31, 'legacy');
