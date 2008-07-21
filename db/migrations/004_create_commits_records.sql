-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (weight, level, count, active) VALUES (50.54, 13, 85, 23);
INSERT INTO commits_records (weight, level, count, active) VALUES (86.19, 28, 1, 81);
