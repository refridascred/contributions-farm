-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    region TEXT,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, owner, region, weight, ratio) VALUES (47, 'green', 'blue', 68.73, 48.45);
INSERT INTO commits_records (count, owner, region, weight, ratio) VALUES (47, 'legacy', 'stable', 14.89, 14.49);
