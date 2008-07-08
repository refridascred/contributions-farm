-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (score, weight, region, count, state) VALUES (26.43, 75.96, 'primary', 45, 'eu-west');
INSERT INTO commits_records (score, weight, region, count, state) VALUES (66.35, 51.93, 'cached', 41, 'staging');
