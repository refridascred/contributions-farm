-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    owner TEXT NOT NULL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (active, label, owner, ratio, count) VALUES (74, 'local', 'stable', 6.67, 73);
INSERT INTO commits_records (active, label, owner, ratio, count) VALUES (49, 'stable', 'staging', 90.84, 27);
