-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    region TEXT,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (ratio, level, region, token, label) VALUES (31.29, 80, 'cached', 'latest', 'eu-west');
INSERT INTO commits_records (ratio, level, region, token, label) VALUES (4.34, 56, 'strict', 'staging', 'open');
