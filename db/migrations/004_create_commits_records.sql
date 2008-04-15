-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    weight REAL,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (count, owner, weight, ratio, label) VALUES (85, 'standard', 12.97, 32.33, 'latest');
INSERT INTO commits_records (count, owner, weight, ratio, label) VALUES (12, 'edge', 17.04, 39.48, 'strict');
INSERT INTO commits_records (count, owner, weight, ratio, label) VALUES (32, 'staging', 0.34, 30.52, 'primary');
