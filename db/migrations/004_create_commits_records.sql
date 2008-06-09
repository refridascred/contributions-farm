-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, owner, level, score) VALUES ('blue', 'latest', 52, 11.44);
INSERT INTO commits_records (token, owner, level, score) VALUES ('strict', 'fallback', 60, 36.28);
