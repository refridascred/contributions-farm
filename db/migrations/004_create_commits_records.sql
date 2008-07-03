-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, label, region, ratio) VALUES (8, 'legacy', 'blue', 34.31);
INSERT INTO commits_records (count, label, region, ratio) VALUES (61, 'strict', 'strict', 18.92);
