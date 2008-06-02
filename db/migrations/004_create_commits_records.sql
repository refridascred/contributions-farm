-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (weight, label, owner) VALUES (54.19, 'staging', 'fallback');
INSERT INTO commits_records (weight, label, owner) VALUES (45.06, 'fallback', 'open');
INSERT INTO commits_records (weight, label, owner) VALUES (7.88, 'cached', 'cached');
