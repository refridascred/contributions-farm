-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, ratio, label, active) VALUES ('latest', 24.75, 'green', 57);
INSERT INTO commits_records (token, ratio, label, active) VALUES ('edge', 30.16, 'legacy', 26);
