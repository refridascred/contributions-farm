-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (token, active, owner, label) VALUES ('standard', 39, 'fallback', 'latest');
INSERT INTO commits_records (token, active, owner, label) VALUES ('standard', 31, 'open', 'latest');
