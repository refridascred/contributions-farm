-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (level, owner, score, token) VALUES (97, 'eu-west', 25.29, 'latest');
INSERT INTO commits_records (level, owner, score, token) VALUES (25, 'edge', 30.36, 'latest');
