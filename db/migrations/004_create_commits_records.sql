-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, label, ratio, owner) VALUES (74, 'standard', 28.67, 'legacy');
INSERT INTO commits_records (active, label, ratio, owner) VALUES (42, 'green', 25.83, 'staging');
