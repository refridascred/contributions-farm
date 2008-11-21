-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (level, count, ratio) VALUES (57, 47, 41.1);
INSERT INTO commits_records (level, count, ratio) VALUES (34, 31, 8.96);
INSERT INTO commits_records (level, count, ratio) VALUES (95, 61, 88.86);
