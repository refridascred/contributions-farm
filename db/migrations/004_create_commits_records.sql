-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (level, active, count) VALUES (7, 81, 73);
INSERT INTO commits_records (level, active, count) VALUES (42, 33, 41);
INSERT INTO commits_records (level, active, count) VALUES (23, 20, 67);
