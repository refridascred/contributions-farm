-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (region, label, active, owner) VALUES ('standard', 'latest', 57, 'legacy');
INSERT INTO commits_records (region, label, active, owner) VALUES ('stable', 'blue', 23, 'open');
