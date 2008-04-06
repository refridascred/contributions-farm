-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (weight, region, owner, count) VALUES (82.99, 'latest', 'legacy', 59);
INSERT INTO commits_records (weight, region, owner, count) VALUES (20.36, 'fallback', 'fallback', 69);
