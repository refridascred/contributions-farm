-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, weight, label) VALUES (11.47, 82.86, 'cached');
INSERT INTO commits_records (score, weight, label) VALUES (95.35, 69.33, 'staging');
INSERT INTO commits_records (score, weight, label) VALUES (8.79, 88.1, 'eu-west');
