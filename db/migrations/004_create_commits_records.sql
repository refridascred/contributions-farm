-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (level, label, token) VALUES (74, 'staging', 'fallback');
INSERT INTO commits_records (level, label, token) VALUES (9, 'edge', 'stable');
INSERT INTO commits_records (level, label, token) VALUES (69, 'blue', 'local');
