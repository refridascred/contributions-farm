-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (score, level, owner) VALUES (62.58, 48, 'cached');
INSERT INTO commits_records (score, level, owner) VALUES (50.95, 86, 'latest');
INSERT INTO commits_records (score, level, owner) VALUES (70.18, 11, 'legacy');
