-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    rank INTEGER,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, token, rank, label, region) VALUES (9.73, 'latest', 42, 'strict', 'strict');
INSERT INTO commits_records (ratio, token, rank, label, region) VALUES (63.86, 'fallback', 69, 'standard', 'green');
INSERT INTO commits_records (ratio, token, rank, label, region) VALUES (47.33, 'legacy', 36, 'legacy', 'blue');
