-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, count, active, owner) VALUES ('staging', 52, 13, 'standard');
INSERT INTO commits_records (token, count, active, owner) VALUES ('edge', 83, 81, 'stable');
INSERT INTO commits_records (token, count, active, owner) VALUES ('standard', 30, 90, 'stable');
