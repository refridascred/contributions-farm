-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (count, ratio, token, active) VALUES (1, 45.64, 'latest', 11);
INSERT INTO commits_records (count, ratio, token, active) VALUES (38, 86.44, 'standard', 91);
INSERT INTO commits_records (count, ratio, token, active) VALUES (81, 83.58, 'open', 21);
