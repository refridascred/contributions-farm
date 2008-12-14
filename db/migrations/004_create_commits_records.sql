-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, weight, region) VALUES ('cached', 26.17, 'primary');
INSERT INTO commits_records (token, weight, region) VALUES ('staging', 3.61, 'latest');
INSERT INTO commits_records (token, weight, region) VALUES ('stable', 93.02, 'edge');
