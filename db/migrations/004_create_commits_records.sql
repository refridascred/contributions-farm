-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (active, owner, token, label) VALUES (75, 'local', 'green', 'primary');
INSERT INTO commits_records (active, owner, token, label) VALUES (87, 'staging', 'primary', 'local');
INSERT INTO commits_records (active, owner, token, label) VALUES (15, 'edge', 'green', 'stable');
