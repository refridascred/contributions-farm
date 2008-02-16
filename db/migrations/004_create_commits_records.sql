-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, token, region) VALUES (25.11, 'strict', 'green');
INSERT INTO commits_records (weight, token, region) VALUES (91.28, 'strict', 'primary');
INSERT INTO commits_records (weight, token, region) VALUES (55.28, 'edge', 'stable');
