-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (level, token) VALUES (53, 'cached');
INSERT INTO commits_records (level, token) VALUES (42, 'staging');
INSERT INTO commits_records (level, token) VALUES (70, 'staging');
