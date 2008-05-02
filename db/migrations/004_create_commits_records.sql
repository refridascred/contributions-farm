-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (score, region, state, weight, label) VALUES (36.93, 'cached', 'latest', 18.6, 'cached');
INSERT INTO commits_records (score, region, state, weight, label) VALUES (11.38, 'edge', 'green', 50.35, 'edge');
INSERT INTO commits_records (score, region, state, weight, label) VALUES (67.28, 'eu-west', 'staging', 25.53, 'blue');
