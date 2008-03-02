-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, weight, region) VALUES (48, 56.9, 'green');
INSERT INTO commits_records (level, weight, region) VALUES (10, 71.82, 'eu-west');
INSERT INTO commits_records (level, weight, region) VALUES (19, 90.68, 'strict');
