-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (ratio, region, count, state, score) VALUES (74.95, 'open', 60, 'standard', 56.66);
INSERT INTO commits_records (ratio, region, count, state, score) VALUES (18.45, 'standard', 42, 'fallback', 60.41);
INSERT INTO commits_records (ratio, region, count, state, score) VALUES (14.84, 'standard', 91, 'latest', 10.2);
