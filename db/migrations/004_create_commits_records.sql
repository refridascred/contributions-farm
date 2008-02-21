-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (active, ratio, count, token) VALUES (58, 24.98, 91, 'standard');
INSERT INTO commits_records (active, ratio, count, token) VALUES (62, 90.48, 79, 'latest');
INSERT INTO commits_records (active, ratio, count, token) VALUES (28, 64.19, 47, 'cached');
