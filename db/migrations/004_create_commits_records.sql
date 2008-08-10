-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (count, level, weight, active, owner) VALUES (11, 52, 68.15, 4, 'cached');
INSERT INTO commits_records (count, level, weight, active, owner) VALUES (73, 66, 14.53, 58, 'stable');
