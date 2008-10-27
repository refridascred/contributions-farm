-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (count, owner, ratio, active, label) VALUES (33, 'strict', 43.41, 63, 'staging');
INSERT INTO commits_records (count, owner, ratio, active, label) VALUES (12, 'stable', 9.27, 89, 'blue');
