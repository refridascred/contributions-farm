-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (score, owner, label, token) VALUES (71.88, 'fallback', 'standard', 'staging');
INSERT INTO commits_records (score, owner, label, token) VALUES (82.88, 'latest', 'legacy', 'cached');
INSERT INTO commits_records (score, owner, label, token) VALUES (16.85, 'local', 'strict', 'eu-west');
