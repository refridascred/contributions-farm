-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, weight, label) VALUES ('staging', 61.57, 'latest');
INSERT INTO commits_records (owner, weight, label) VALUES ('staging', 83.05, 'strict');
INSERT INTO commits_records (owner, weight, label) VALUES ('eu-west', 36.24, 'open');
