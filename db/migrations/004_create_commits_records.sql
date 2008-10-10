-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (token, label) VALUES ('primary', 'standard');
INSERT INTO commits_records (token, label) VALUES ('green', 'fallback');
INSERT INTO commits_records (token, label) VALUES ('blue', 'eu-west');
