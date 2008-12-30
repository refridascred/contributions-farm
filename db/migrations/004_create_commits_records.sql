-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, owner, state, count, label) VALUES (96.47, 'fallback', 'green', 88, 'latest');
INSERT INTO commits_records (ratio, owner, state, count, label) VALUES (75.88, 'standard', 'staging', 3, 'staging');
INSERT INTO commits_records (ratio, owner, state, count, label) VALUES (67.95, 'edge', 'legacy', 91, 'fallback');
