-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, active, weight, level) VALUES (49, 46, 31.71, 55);
INSERT INTO commits_records (count, active, weight, level) VALUES (72, 53, 10.04, 88);
INSERT INTO commits_records (count, active, weight, level) VALUES (65, 5, 83.7, 14);
