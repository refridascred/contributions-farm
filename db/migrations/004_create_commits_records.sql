-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    token TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (region, owner, token, label, active) VALUES ('latest', 'eu-west', 'cached', 'fallback', 23);
INSERT INTO commits_records (region, owner, token, label, active) VALUES ('primary', 'strict', 'blue', 'latest', 2);
INSERT INTO commits_records (region, owner, token, label, active) VALUES ('cached', 'fallback', 'green', 'staging', 56);
