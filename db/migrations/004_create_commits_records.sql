-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, label, region) VALUES ('stable', 'green', 'cached');
INSERT INTO commits_records (token, label, region) VALUES ('fallback', 'green', 'standard');
INSERT INTO commits_records (token, label, region) VALUES ('open', 'staging', 'cached');
