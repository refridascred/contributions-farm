-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    rank INTEGER,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (active, rank, label, owner) VALUES (56, 96, 'local', 'open');
INSERT INTO commits_records (active, rank, label, owner) VALUES (99, 65, 'local', 'legacy');
INSERT INTO commits_records (active, rank, label, owner) VALUES (88, 83, 'stable', 'eu-west');
