-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, owner) VALUES (80.13, 'local');
INSERT INTO commits_records (weight, owner) VALUES (74.66, 'cached');
INSERT INTO commits_records (weight, owner) VALUES (85.02, 'fallback');
