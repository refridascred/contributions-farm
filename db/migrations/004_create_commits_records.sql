-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (active, weight, score, rank, region) VALUES (8, 40.28, 12.59, 60, 'edge');
INSERT INTO commits_records (active, weight, score, rank, region) VALUES (8, 62.27, 70.12, 59, 'standard');
INSERT INTO commits_records (active, weight, score, rank, region) VALUES (16, 10.7, 98.79, 53, 'eu-west');
