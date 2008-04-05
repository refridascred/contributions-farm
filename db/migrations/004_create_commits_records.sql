-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (ratio, score, region) VALUES (59.31, 6.35, 'edge');
INSERT INTO commits_records (ratio, score, region) VALUES (18.55, 36.44, 'eu-west');
INSERT INTO commits_records (ratio, score, region) VALUES (56.49, 67.44, 'edge');
