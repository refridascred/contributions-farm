-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (active, weight, ratio, count, region) VALUES (39, 55.92, 45.68, 26, 'green');
INSERT INTO commits_records (active, weight, ratio, count, region) VALUES (22, 17.93, 79.22, 36, 'stable');
INSERT INTO commits_records (active, weight, ratio, count, region) VALUES (84, 17.66, 59.06, 97, 'primary');
