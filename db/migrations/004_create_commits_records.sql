-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, count, level, region) VALUES (3.65, 23, 11, 'staging');
INSERT INTO commits_records (weight, count, level, region) VALUES (14.04, 90, 64, 'open');
INSERT INTO commits_records (weight, count, level, region) VALUES (24.24, 81, 88, 'latest');
