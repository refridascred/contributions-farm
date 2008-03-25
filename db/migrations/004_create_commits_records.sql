-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, region, owner) VALUES ('primary', 'cached', 'green');
INSERT INTO commits_records (token, region, owner) VALUES ('fallback', 'local', 'eu-west');
INSERT INTO commits_records (token, region, owner) VALUES ('staging', 'latest', 'local');
