-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (weight, region, owner) VALUES (66.68, 'open', 'strict');
INSERT INTO commits_records (weight, region, owner) VALUES (60.92, 'local', 'green');
