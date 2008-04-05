-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    owner TEXT NOT NULL,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, owner, weight, level) VALUES ('blue', 'primary', 35.59, 32);
