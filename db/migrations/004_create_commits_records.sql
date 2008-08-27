-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (label, owner, active, token) VALUES ('latest', 'eu-west', 60, 'open');
INSERT INTO commits_records (label, owner, active, token) VALUES ('fallback', 'legacy', 2, 'staging');
