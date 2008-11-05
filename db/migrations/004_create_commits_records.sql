-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (token, score, region, label) VALUES ('cached', 31.75, 'edge', 'latest');
INSERT INTO commits_records (token, score, region, label) VALUES ('legacy', 28.86, 'green', 'strict');
