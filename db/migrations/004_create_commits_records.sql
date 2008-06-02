-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    region TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (token, owner, region, ratio, score) VALUES ('legacy', 'local', 'standard', 90.64, 79.12);
INSERT INTO commits_records (token, owner, region, ratio, score) VALUES ('legacy', 'primary', 'staging', 0.12, 94.23);
INSERT INTO commits_records (token, owner, region, ratio, score) VALUES ('blue', 'legacy', 'legacy', 58.32, 34.22);
