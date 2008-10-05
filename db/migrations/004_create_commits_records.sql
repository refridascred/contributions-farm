-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (score, active, token) VALUES (94.67, 25, 'stable');
INSERT INTO commits_records (score, active, token) VALUES (21.93, 12, 'standard');
INSERT INTO commits_records (score, active, token) VALUES (26.55, 94, 'latest');
