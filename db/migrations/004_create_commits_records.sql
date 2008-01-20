-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (region, ratio, token, level) VALUES ('edge', 18.17, 'staging', 63);
INSERT INTO commits_records (region, ratio, token, level) VALUES ('edge', 89.13, 'latest', 41);
