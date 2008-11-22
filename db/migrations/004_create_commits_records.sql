-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, ratio, token) VALUES (49, 18.51, 'local');
INSERT INTO commits_records (active, ratio, token) VALUES (61, 62.19, 'eu-west');
INSERT INTO commits_records (active, ratio, token) VALUES (18, 69.18, 'standard');
