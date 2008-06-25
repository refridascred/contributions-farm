-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, owner, label) VALUES (54, 'staging', 'primary');
INSERT INTO commits_records (active, owner, label) VALUES (48, 'open', 'primary');
INSERT INTO commits_records (active, owner, label) VALUES (96, 'standard', 'strict');
