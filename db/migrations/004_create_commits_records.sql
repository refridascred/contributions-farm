-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (ratio, region, weight, score, label) VALUES (84.09, 'local', 31.17, 37.42, 'strict');
INSERT INTO commits_records (ratio, region, weight, score, label) VALUES (92.01, 'edge', 31.46, 46.2, 'stable');
