-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    weight REAL,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (ratio, label, weight, region, token) VALUES (54.18, 'open', 71.69, 'latest', 'cached');
INSERT INTO commits_records (ratio, label, weight, region, token) VALUES (34.87, 'eu-west', 96.28, 'standard', 'edge');
