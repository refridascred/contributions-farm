-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, weight, ratio) VALUES (49, 65.51, 67.72);
INSERT INTO commits_records (count, weight, ratio) VALUES (44, 61.16, 34.51);
