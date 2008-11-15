-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (ratio, weight, score, owner, region) VALUES (73.58, 37.08, 52.41, 'eu-west', 'eu-west');
INSERT INTO commits_records (ratio, weight, score, owner, region) VALUES (78.19, 9.54, 60.48, 'stable', 'stable');
