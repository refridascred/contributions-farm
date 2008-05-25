-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    owner TEXT NOT NULL,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (ratio, owner, weight, active) VALUES (89.63, 'open', 22.74, 2);
INSERT INTO commits_records (ratio, owner, weight, active) VALUES (83.88, 'staging', 62.63, 33);
INSERT INTO commits_records (ratio, owner, weight, active) VALUES (38.84, 'standard', 15.05, 7);
