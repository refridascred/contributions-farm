-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, label, owner) VALUES ('fallback', 'fallback', 'cached');
INSERT INTO commits_records (token, label, owner) VALUES ('eu-west', 'eu-west', 'standard');
INSERT INTO commits_records (token, label, owner) VALUES ('latest', 'blue', 'eu-west');
