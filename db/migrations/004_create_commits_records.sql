-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (score, owner) VALUES (84.36, 'latest');
INSERT INTO commits_records (score, owner) VALUES (95.17, 'fallback');
INSERT INTO commits_records (score, owner) VALUES (98.65, 'fallback');
