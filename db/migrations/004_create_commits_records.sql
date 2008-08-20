-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (level, rank, score, region) VALUES (33, 88, 65.73, 'blue');
INSERT INTO commits_records (level, rank, score, region) VALUES (20, 66, 95.01, 'latest');
INSERT INTO commits_records (level, rank, score, region) VALUES (1, 39, 64.11, 'blue');
