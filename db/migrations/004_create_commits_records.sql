-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (count, owner, ratio, active) VALUES (86, 'latest', 79.57, 38);
INSERT INTO commits_records (count, owner, ratio, active) VALUES (76, 'blue', 57.4, 25);
INSERT INTO commits_records (count, owner, ratio, active) VALUES (79, 'cached', 85.39, 29);
