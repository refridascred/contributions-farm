-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, region, ratio, state, score) VALUES (12, 'latest', 35.92, 'legacy', 77.75);
INSERT INTO commits_records (count, region, ratio, state, score) VALUES (3, 'open', 26.47, 'green', 92.78);
INSERT INTO commits_records (count, region, ratio, state, score) VALUES (38, 'local', 38.72, 'staging', 38.46);
