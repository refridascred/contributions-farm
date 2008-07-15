-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (weight, level, count) VALUES (43.19, 9, 53);
INSERT INTO commits_records (weight, level, count) VALUES (43.63, 23, 7);
INSERT INTO commits_records (weight, level, count) VALUES (53.04, 85, 51);
