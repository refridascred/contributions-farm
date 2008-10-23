-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (weight, label, count, owner) VALUES (80.88, 'staging', 15, 'standard');
INSERT INTO commits_records (weight, label, count, owner) VALUES (76.27, 'green', 73, 'local');
