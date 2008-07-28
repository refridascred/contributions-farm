-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (state, owner, count, ratio, token) VALUES ('staging', 'staging', 88, 12.42, 'cached');
INSERT INTO commits_records (state, owner, count, ratio, token) VALUES ('standard', 'primary', 94, 62.48, 'edge');
INSERT INTO commits_records (state, owner, count, ratio, token) VALUES ('fallback', 'stable', 75, 18.24, 'cached');
