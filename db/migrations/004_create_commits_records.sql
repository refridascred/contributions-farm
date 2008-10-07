-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (weight, owner, label) VALUES (0.83, 'legacy', 'strict');
INSERT INTO commits_records (weight, owner, label) VALUES (86.79, 'blue', 'edge');
