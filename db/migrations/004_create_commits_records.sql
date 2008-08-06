-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (level, rank, score, owner) VALUES (18, 24, 38.4, 'local');
INSERT INTO commits_records (level, rank, score, owner) VALUES (15, 3, 88.68, 'edge');
INSERT INTO commits_records (level, rank, score, owner) VALUES (13, 44, 0.5, 'eu-west');
