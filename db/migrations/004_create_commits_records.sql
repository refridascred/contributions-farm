-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (active, count, weight, region, ratio) VALUES (42, 32, 58.36, 'primary', 10.75);
INSERT INTO commits_records (active, count, weight, region, ratio) VALUES (88, 65, 76.95, 'latest', 78.57);
