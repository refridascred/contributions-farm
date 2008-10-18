-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, weight, region) VALUES (79, 68.0, 'staging');
INSERT INTO commits_records (level, weight, region) VALUES (70, 93.83, 'stable');
INSERT INTO commits_records (level, weight, region) VALUES (84, 6.73, 'stable');
