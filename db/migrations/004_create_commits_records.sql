-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (count, owner, region) VALUES (35, 'edge', 'edge');
INSERT INTO commits_records (count, owner, region) VALUES (95, 'stable', 'open');
INSERT INTO commits_records (count, owner, region) VALUES (7, 'blue', 'staging');
