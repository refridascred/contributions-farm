-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, score, ratio, token) VALUES (79.55, 56.52, 63.29, 'standard');
INSERT INTO commits_records (weight, score, ratio, token) VALUES (6.72, 72.71, 16.45, 'stable');
