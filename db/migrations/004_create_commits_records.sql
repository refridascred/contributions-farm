-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, region, count, label, token) VALUES (31.93, 'primary', 50, 'open', 'staging');
INSERT INTO commits_records (score, region, count, label, token) VALUES (24.68, 'local', 77, 'strict', 'edge');
INSERT INTO commits_records (score, region, count, label, token) VALUES (40.81, 'standard', 17, 'latest', 'latest');
