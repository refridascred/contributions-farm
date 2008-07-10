-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (ratio, region, owner, score, level) VALUES (89.27, 'standard', 'staging', 2.88, 91);
INSERT INTO commits_records (ratio, region, owner, score, level) VALUES (3.34, 'open', 'eu-west', 11.78, 72);
INSERT INTO commits_records (ratio, region, owner, score, level) VALUES (37.51, 'blue', 'fallback', 48.24, 49);
