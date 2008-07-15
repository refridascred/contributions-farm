-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (token, owner, ratio, state, count) VALUES ('stable', 'staging', 24.33, 'legacy', 56);
INSERT INTO commits_records (token, owner, ratio, state, count) VALUES ('latest', 'fallback', 68.51, 'green', 57);
