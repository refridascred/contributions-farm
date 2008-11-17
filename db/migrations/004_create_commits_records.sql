-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (ratio, score, token, count, region) VALUES (44.68, 35.29, 'eu-west', 62, 'primary');
INSERT INTO commits_records (ratio, score, token, count, region) VALUES (77.42, 37.33, 'stable', 49, 'standard');
INSERT INTO commits_records (ratio, score, token, count, region) VALUES (31.42, 42.28, 'legacy', 11, 'local');
