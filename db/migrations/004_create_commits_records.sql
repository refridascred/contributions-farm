-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (score, ratio, owner) VALUES (49.67, 41.38, 'open');
INSERT INTO commits_records (score, ratio, owner) VALUES (1.05, 56.01, 'eu-west');
