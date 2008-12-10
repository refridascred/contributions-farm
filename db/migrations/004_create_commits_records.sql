-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, region, state, ratio, weight) VALUES (28, 'fallback', 'latest', 85.56, 96.29);
INSERT INTO commits_records (count, region, state, ratio, weight) VALUES (49, 'green', 'edge', 56.92, 70.12);
INSERT INTO commits_records (count, region, state, ratio, weight) VALUES (91, 'standard', 'standard', 77.8, 85.55);
