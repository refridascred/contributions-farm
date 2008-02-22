-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (level, weight, token) VALUES (99, 26.29, 'primary');
INSERT INTO commits_records (level, weight, token) VALUES (32, 88.42, 'eu-west');
