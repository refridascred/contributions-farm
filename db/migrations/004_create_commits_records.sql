-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, owner, score, region) VALUES (33.12, 'blue', 3.77, 'blue');
INSERT INTO commits_records (ratio, owner, score, region) VALUES (98.44, 'blue', 5.22, 'fallback');
INSERT INTO commits_records (ratio, owner, score, region) VALUES (64.03, 'cached', 89.59, 'cached');
