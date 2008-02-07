-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (owner, label, active, token) VALUES ('stable', 'staging', 72, 'primary');
INSERT INTO commits_records (owner, label, active, token) VALUES ('legacy', 'primary', 38, 'fallback');
INSERT INTO commits_records (owner, label, active, token) VALUES ('open', 'cached', 24, 'local');
