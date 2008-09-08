-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (score, ratio, region) VALUES (94.66, 66.81, 'open');
INSERT INTO commits_records (score, ratio, region) VALUES (36.93, 72.31, 'blue');
