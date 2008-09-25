-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (weight, state, count, score, region) VALUES (18.42, 'strict', 57, 17.44, 'latest');
INSERT INTO commits_records (weight, state, count, score, region) VALUES (90.78, 'staging', 14, 85.86, 'standard');
INSERT INTO commits_records (weight, state, count, score, region) VALUES (4.71, 'legacy', 31, 74.9, 'edge');
