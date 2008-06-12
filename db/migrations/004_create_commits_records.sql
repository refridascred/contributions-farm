-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (weight, score, ratio, owner, region) VALUES (69.85, 53.69, 31.34, 'staging', 'primary');
INSERT INTO commits_records (weight, score, ratio, owner, region) VALUES (20.55, 29.05, 6.42, 'legacy', 'blue');
