-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (active, rank, score, region) VALUES (56, 52, 69.81, 'staging');
INSERT INTO commits_records (active, rank, score, region) VALUES (31, 89, 60.57, 'stable');
INSERT INTO commits_records (active, rank, score, region) VALUES (70, 74, 0.13, 'eu-west');
