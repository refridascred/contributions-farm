-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (token, label, ratio, active, owner) VALUES ('green', 'green', 35.3, 39, 'staging');
INSERT INTO commits_records (token, label, ratio, active, owner) VALUES ('strict', 'edge', 73.09, 21, 'eu-west');
INSERT INTO commits_records (token, label, ratio, active, owner) VALUES ('green', 'standard', 10.8, 97, 'strict');
