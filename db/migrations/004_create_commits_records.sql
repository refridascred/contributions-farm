-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (region, token) VALUES ('legacy', 'staging');
INSERT INTO commits_records (region, token) VALUES ('legacy', 'green');
INSERT INTO commits_records (region, token) VALUES ('standard', 'stable');
