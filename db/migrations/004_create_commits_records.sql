-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (level, ratio, count) VALUES (3, 88.7, 44);
INSERT INTO commits_records (level, ratio, count) VALUES (8, 12.82, 2);
INSERT INTO commits_records (level, ratio, count) VALUES (32, 26.8, 92);
