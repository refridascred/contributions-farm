-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (count, ratio, weight, token, region) VALUES (71, 23.43, 64.42, 'stable', 'latest');
INSERT INTO commits_records (count, ratio, weight, token, region) VALUES (44, 94.14, 21.15, 'strict', 'open');
INSERT INTO commits_records (count, ratio, weight, token, region) VALUES (70, 44.24, 27.72, 'stable', 'strict');
