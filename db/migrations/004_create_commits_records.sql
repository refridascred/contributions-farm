-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (score, active, owner) VALUES (98.43, 64, 'eu-west');
INSERT INTO commits_records (score, active, owner) VALUES (75.56, 18, 'edge');
INSERT INTO commits_records (score, active, owner) VALUES (34.36, 58, 'edge');
