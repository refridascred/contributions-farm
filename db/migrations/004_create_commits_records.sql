-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (ratio, region, owner, score, token) VALUES (4.29, 'open', 'legacy', 6.23, 'standard');
INSERT INTO commits_records (ratio, region, owner, score, token) VALUES (34.43, 'primary', 'legacy', 94.88, 'stable');
INSERT INTO commits_records (ratio, region, owner, score, token) VALUES (89.87, 'green', 'local', 86.71, 'staging');
