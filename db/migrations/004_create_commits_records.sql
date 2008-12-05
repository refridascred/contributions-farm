-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, region, state, count) VALUES (62.65, 'green', 'latest', 89);
INSERT INTO commits_records (ratio, region, state, count) VALUES (18.1, 'cached', 'edge', 82);
INSERT INTO commits_records (ratio, region, state, count) VALUES (85.49, 'staging', 'edge', 86);
