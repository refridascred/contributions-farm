-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (ratio, token) VALUES (62.98, 'standard');
INSERT INTO commits_records (ratio, token) VALUES (60.93, 'blue');
INSERT INTO commits_records (ratio, token) VALUES (59.71, 'local');
