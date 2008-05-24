-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, active, ratio, region) VALUES (94.34, 94, 93.78, 'blue');
INSERT INTO commits_records (score, active, ratio, region) VALUES (67.91, 76, 12.69, 'staging');
