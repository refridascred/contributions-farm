-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (active, region, owner) VALUES (51, 'primary', 'edge');
INSERT INTO commits_records (active, region, owner) VALUES (98, 'staging', 'latest');
INSERT INTO commits_records (active, region, owner) VALUES (20, 'edge', 'open');
