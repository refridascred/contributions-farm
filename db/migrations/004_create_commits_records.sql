-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (ratio, active, count, weight, owner) VALUES (3.66, 9, 60, 67.95, 'edge');
INSERT INTO commits_records (ratio, active, count, weight, owner) VALUES (11.72, 13, 51, 45.9, 'fallback');
INSERT INTO commits_records (ratio, active, count, weight, owner) VALUES (54.76, 23, 32, 20.49, 'primary');
