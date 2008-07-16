-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (ratio, owner, level, active, count) VALUES (66.09, 'latest', 63, 30, 90);
INSERT INTO commits_records (ratio, owner, level, active, count) VALUES (54.34, 'primary', 17, 77, 14);
