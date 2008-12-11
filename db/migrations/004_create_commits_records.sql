-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, ratio, active, region) VALUES (26, 9.88, 62, 'edge');
INSERT INTO commits_records (count, ratio, active, region) VALUES (42, 24.28, 68, 'blue');
INSERT INTO commits_records (count, ratio, active, region) VALUES (99, 8.09, 83, 'standard');
