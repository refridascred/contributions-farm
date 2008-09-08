-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (score, count, ratio) VALUES (67.4, 72, 11.52);
INSERT INTO commits_records (score, count, ratio) VALUES (97.29, 99, 67.42);
INSERT INTO commits_records (score, count, ratio) VALUES (37.23, 49, 26.41);
