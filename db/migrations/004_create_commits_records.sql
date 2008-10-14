-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, score, count, region, label) VALUES ('stable', 37.57, 91, 'green', 'green');
INSERT INTO commits_records (token, score, count, region, label) VALUES ('stable', 31.69, 9, 'cached', 'latest');
INSERT INTO commits_records (token, score, count, region, label) VALUES ('standard', 25.87, 88, 'staging', 'primary');
