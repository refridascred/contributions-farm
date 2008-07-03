-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (owner, count, label, token, active) VALUES ('strict', 90, 'eu-west', 'cached', 18);
INSERT INTO commits_records (owner, count, label, token, active) VALUES ('staging', 23, 'primary', 'cached', 21);
