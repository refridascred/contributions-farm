-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (ratio, count, level) VALUES (42.82, 75, 89);
INSERT INTO commits_records (ratio, count, level) VALUES (73.26, 56, 81);
INSERT INTO commits_records (ratio, count, level) VALUES (23.04, 90, 89);
