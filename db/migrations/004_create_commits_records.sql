-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, level, region) VALUES (93.69, 73, 'primary');
INSERT INTO commits_records (weight, level, region) VALUES (40.19, 34, 'eu-west');
INSERT INTO commits_records (weight, level, region) VALUES (89.84, 81, 'latest');
