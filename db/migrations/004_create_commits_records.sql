-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, count, region) VALUES (92.23, 71, 'green');
INSERT INTO commits_records (ratio, count, region) VALUES (88.79, 31, 'cached');
INSERT INTO commits_records (ratio, count, region) VALUES (66.2, 25, 'strict');
