-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, ratio, score, region) VALUES (77, 68.89, 40.13, 'eu-west');
INSERT INTO commits_records (level, ratio, score, region) VALUES (72, 35.47, 28.34, 'local');
