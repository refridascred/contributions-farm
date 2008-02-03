-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, ratio, label) VALUES (39.38, 53.88, 'strict');
INSERT INTO commits_records (score, ratio, label) VALUES (30.89, 94.89, 'legacy');
INSERT INTO commits_records (score, ratio, label) VALUES (33.34, 62.14, 'edge');
