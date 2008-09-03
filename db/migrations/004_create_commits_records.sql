-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (weight, count, state, ratio, region) VALUES (37.01, 51, 'green', 58.28, 'stable');
INSERT INTO commits_records (weight, count, state, ratio, region) VALUES (82.24, 63, 'legacy', 16.11, 'blue');
INSERT INTO commits_records (weight, count, state, ratio, region) VALUES (22.37, 26, 'staging', 47.73, 'staging');
