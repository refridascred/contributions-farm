-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (owner, token, region) VALUES ('staging', 'green', 'eu-west');
INSERT INTO commits_records (owner, token, region) VALUES ('latest', 'fallback', 'fallback');
