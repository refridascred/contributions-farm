-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, score, owner) VALUES (78.51, 24.38, 'blue');
INSERT INTO commits_records (weight, score, owner) VALUES (67.92, 23.86, 'cached');
INSERT INTO commits_records (weight, score, owner) VALUES (70.43, 59.48, 'primary');
