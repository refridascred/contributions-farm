-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, owner, weight) VALUES (94, 'edge', 18.45);
INSERT INTO commits_records (active, owner, weight) VALUES (23, 'open', 82.91);
INSERT INTO commits_records (active, owner, weight) VALUES (81, 'stable', 40.17);
