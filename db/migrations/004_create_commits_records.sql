-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (region, weight, token) VALUES ('fallback', 78.39, 'edge');
INSERT INTO commits_records (region, weight, token) VALUES ('staging', 37.98, 'primary');
INSERT INTO commits_records (region, weight, token) VALUES ('eu-west', 78.51, 'blue');
