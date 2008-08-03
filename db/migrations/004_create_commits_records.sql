-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, owner, rank, label) VALUES (7, 'legacy', 99, 'eu-west');
INSERT INTO commits_records (active, owner, rank, label) VALUES (87, 'stable', 43, 'local');
INSERT INTO commits_records (active, owner, rank, label) VALUES (20, 'eu-west', 28, 'standard');
