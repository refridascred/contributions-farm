-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (ratio, score, level, region) VALUES (2.5, 25.11, 74, 'eu-west');
INSERT INTO commits_records (ratio, score, level, region) VALUES (97.18, 84.83, 26, 'staging');
