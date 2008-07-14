-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, weight, owner, level) VALUES ('standard', 9.82, 'staging', 66);
