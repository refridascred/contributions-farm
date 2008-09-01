-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (score, token) VALUES (63.47, 'eu-west');
INSERT INTO commits_records (score, token) VALUES (22.38, 'blue');
INSERT INTO commits_records (score, token) VALUES (50.92, 'blue');
