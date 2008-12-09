-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (weight, ratio, owner) VALUES (64.88, 1.01, 'standard');
INSERT INTO commits_records (weight, ratio, owner) VALUES (41.99, 89.42, 'staging');
INSERT INTO commits_records (weight, ratio, owner) VALUES (14.56, 85.1, 'local');
