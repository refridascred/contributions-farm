-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, count, active) VALUES (18.58, 4, 18);
INSERT INTO commits_records (ratio, count, active) VALUES (84.94, 44, 68);
INSERT INTO commits_records (ratio, count, active) VALUES (35.11, 47, 41);
