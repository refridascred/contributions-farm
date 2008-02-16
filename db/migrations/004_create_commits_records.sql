-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (token, weight, ratio, region) VALUES ('cached', 34.93, 40.0, 'strict');
INSERT INTO commits_records (token, weight, ratio, region) VALUES ('edge', 18.26, 39.98, 'fallback');
INSERT INTO commits_records (token, weight, ratio, region) VALUES ('blue', 24.11, 24.12, 'cached');
