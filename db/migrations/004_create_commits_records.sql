-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (active, count, owner, label) VALUES (97, 42, 'local', 'blue');
INSERT INTO commits_records (active, count, owner, label) VALUES (38, 98, 'staging', 'eu-west');
INSERT INTO commits_records (active, count, owner, label) VALUES (89, 98, 'local', 'blue');
