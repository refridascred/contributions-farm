-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (weight, owner, score, region, token) VALUES (97.66, 'primary', 71.75, 'edge', 'latest');
INSERT INTO commits_records (weight, owner, score, region, token) VALUES (58.21, 'fallback', 79.05, 'blue', 'edge');
