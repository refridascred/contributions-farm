-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (score, owner) VALUES (98.29, 'legacy');
INSERT INTO commits_records (score, owner) VALUES (53.7, 'stable');
INSERT INTO commits_records (score, owner) VALUES (28.39, 'stable');
