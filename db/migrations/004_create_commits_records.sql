-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (ratio, token, level) VALUES (85.11, 'primary', 96);
INSERT INTO commits_records (ratio, token, level) VALUES (47.97, 'cached', 11);
INSERT INTO commits_records (ratio, token, level) VALUES (20.93, 'edge', 24);
