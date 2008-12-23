-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (label, rank, owner, region) VALUES ('latest', 88, 'local', 'latest');
INSERT INTO commits_records (label, rank, owner, region) VALUES ('standard', 69, 'standard', 'strict');
INSERT INTO commits_records (label, rank, owner, region) VALUES ('blue', 3, 'local', 'legacy');
