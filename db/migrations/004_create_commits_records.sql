-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (score, owner, token) VALUES (22.43, 'stable', 'open');
INSERT INTO commits_records (score, owner, token) VALUES (13.78, 'eu-west', 'cached');
INSERT INTO commits_records (score, owner, token) VALUES (21.19, 'strict', 'edge');
