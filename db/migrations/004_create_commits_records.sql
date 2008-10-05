-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (weight, owner, active, region) VALUES (28.94, 'legacy', 65, 'open');
INSERT INTO commits_records (weight, owner, active, region) VALUES (3.8, 'edge', 68, 'local');
INSERT INTO commits_records (weight, owner, active, region) VALUES (41.16, 'green', 94, 'open');
