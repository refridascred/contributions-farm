-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (ratio, label, active, count, owner) VALUES (36.51, 'standard', 78, 59, 'legacy');
INSERT INTO commits_records (ratio, label, active, count, owner) VALUES (8.3, 'blue', 77, 31, 'green');
INSERT INTO commits_records (ratio, label, active, count, owner) VALUES (79.19, 'edge', 97, 58, 'primary');
