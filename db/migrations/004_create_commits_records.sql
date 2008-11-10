-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (weight, region, count, token) VALUES (19.6, 'primary', 30, 'cached');
INSERT INTO commits_records (weight, region, count, token) VALUES (98.12, 'eu-west', 33, 'fallback');
