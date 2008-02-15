-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, level, region, token) VALUES (10.78, 72, 'latest', 'eu-west');
INSERT INTO commits_records (weight, level, region, token) VALUES (62.4, 91, 'cached', 'staging');
