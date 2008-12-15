-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (score, region, count) VALUES (14.59, 'legacy', 20);
INSERT INTO commits_records (score, region, count) VALUES (76.26, 'green', 93);
INSERT INTO commits_records (score, region, count) VALUES (51.07, 'strict', 62);
