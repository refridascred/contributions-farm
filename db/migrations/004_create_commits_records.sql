-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (ratio, region, state, label) VALUES (5.31, 'latest', 'cached', 'strict');
INSERT INTO commits_records (ratio, region, state, label) VALUES (12.36, 'standard', 'open', 'stable');
