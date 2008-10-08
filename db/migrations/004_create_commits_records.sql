-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (weight, score, token, rank, region) VALUES (95.06, 97.64, 'primary', 40, 'edge');
INSERT INTO commits_records (weight, score, token, rank, region) VALUES (2.75, 66.62, 'staging', 90, 'green');
