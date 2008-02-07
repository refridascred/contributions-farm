-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (token, label, region) VALUES ('staging', 'open', 'eu-west');
INSERT INTO commits_records (token, label, region) VALUES ('open', 'legacy', 'staging');
INSERT INTO commits_records (token, label, region) VALUES ('fallback', 'staging', 'eu-west');
