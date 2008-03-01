-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, owner, ratio, count) VALUES (45, 'standard', 46.73, 77);
INSERT INTO commits_records (active, owner, ratio, count) VALUES (23, 'blue', 5.15, 29);
