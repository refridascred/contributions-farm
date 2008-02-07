-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (ratio, score, token) VALUES (50.44, 63.32, 'open');
INSERT INTO commits_records (ratio, score, token) VALUES (30.17, 32.86, 'staging');
INSERT INTO commits_records (ratio, score, token) VALUES (54.87, 95.2, 'edge');
