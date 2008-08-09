-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (level, count, weight) VALUES (86, 35, 23.59);
INSERT INTO commits_records (level, count, weight) VALUES (42, 24, 16.14);
INSERT INTO commits_records (level, count, weight) VALUES (86, 27, 81.72);
