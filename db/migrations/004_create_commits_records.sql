-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (ratio, active, owner, count) VALUES (32.52, 82, 'stable', 43);
INSERT INTO commits_records (ratio, active, owner, count) VALUES (59.04, 39, 'open', 27);
INSERT INTO commits_records (ratio, active, owner, count) VALUES (5.42, 88, 'latest', 0);
