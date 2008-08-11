-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (level, score, region, owner, ratio) VALUES (0, 58.47, 'staging', 'local', 24.64);
INSERT INTO commits_records (level, score, region, owner, ratio) VALUES (3, 16.29, 'latest', 'latest', 73.24);
INSERT INTO commits_records (level, score, region, owner, ratio) VALUES (44, 33.66, 'eu-west', 'open', 80.51);
