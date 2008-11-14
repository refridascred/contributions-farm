-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (score, owner, region) VALUES (61.4, 'standard', 'blue');
INSERT INTO commits_records (score, owner, region) VALUES (12.1, 'cached', 'fallback');
INSERT INTO commits_records (score, owner, region) VALUES (77.99, 'latest', 'cached');
