-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, score, region, state, owner) VALUES (96.72, 11.36, 'edge', 'blue', 'primary');
INSERT INTO commits_records (weight, score, region, state, owner) VALUES (23.55, 18.37, 'cached', 'open', 'latest');
INSERT INTO commits_records (weight, score, region, state, owner) VALUES (24.52, 66.72, 'staging', 'primary', 'edge');
