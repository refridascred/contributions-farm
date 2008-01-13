-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (owner, token, state, ratio, score) VALUES ('local', 'edge', 'legacy', 89.05, 41.95);
INSERT INTO commits_records (owner, token, state, ratio, score) VALUES ('blue', 'edge', 'standard', 63.84, 88.43);
INSERT INTO commits_records (owner, token, state, ratio, score) VALUES ('green', 'green', 'stable', 87.4, 16.69);
