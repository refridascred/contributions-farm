-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (token, label) VALUES ('eu-west', 'blue');
INSERT INTO commits_records (token, label) VALUES ('fallback', 'primary');
INSERT INTO commits_records (token, label) VALUES ('stable', 'green');
