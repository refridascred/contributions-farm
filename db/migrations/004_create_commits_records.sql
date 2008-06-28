-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (label, ratio, owner, count, state) VALUES ('green', 51.58, 'stable', 29, 'edge');
INSERT INTO commits_records (label, ratio, owner, count, state) VALUES ('standard', 78.06, 'green', 83, 'local');
