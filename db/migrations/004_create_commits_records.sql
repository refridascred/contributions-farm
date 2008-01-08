-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    weight REAL,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (active, weight, owner, region) VALUES (84, 49.73, 'local', 'eu-west');
INSERT INTO commits_records (active, weight, owner, region) VALUES (1, 13.95, 'legacy', 'strict');
