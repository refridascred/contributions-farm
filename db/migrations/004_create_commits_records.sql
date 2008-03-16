-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (weight, region, count, token) VALUES (21.0, 'staging', 74, 'primary');
INSERT INTO commits_records (weight, region, count, token) VALUES (56.3, 'primary', 55, 'cached');
INSERT INTO commits_records (weight, region, count, token) VALUES (13.41, 'strict', 10, 'green');
