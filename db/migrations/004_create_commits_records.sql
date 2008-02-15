-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, weight, owner, region) VALUES (73.82, 14.86, 'latest', 'stable');
INSERT INTO commits_records (score, weight, owner, region) VALUES (57.35, 61.19, 'blue', 'green');
INSERT INTO commits_records (score, weight, owner, region) VALUES (64.84, 29.09, 'local', 'open');
