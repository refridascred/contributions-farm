-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (level, owner, score, token, rank) VALUES (70, 'legacy', 82.01, 'local', 23);
INSERT INTO commits_records (level, owner, score, token, rank) VALUES (3, 'strict', 29.72, 'cached', 24);
INSERT INTO commits_records (level, owner, score, token, rank) VALUES (41, 'fallback', 3.06, 'staging', 85);
