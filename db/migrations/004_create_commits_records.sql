-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (weight, owner, active) VALUES (78.08, 'cached', 26);
INSERT INTO commits_records (weight, owner, active) VALUES (52.06, 'staging', 49);
