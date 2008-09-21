-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (label, token, level) VALUES ('latest', 'local', 82);
INSERT INTO commits_records (label, token, level) VALUES ('fallback', 'cached', 67);
