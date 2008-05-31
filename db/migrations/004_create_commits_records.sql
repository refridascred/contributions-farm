-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    owner TEXT NOT NULL,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (active, level, owner, label) VALUES (89, 61, 'cached', 'eu-west');
INSERT INTO commits_records (active, level, owner, label) VALUES (90, 90, 'local', 'standard');
INSERT INTO commits_records (active, level, owner, label) VALUES (65, 46, 'latest', 'edge');
