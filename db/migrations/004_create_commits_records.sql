-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, active, token) VALUES (51.47, 81, 'cached');
INSERT INTO commits_records (ratio, active, token) VALUES (82.16, 93, 'edge');
INSERT INTO commits_records (ratio, active, token) VALUES (18.86, 94, 'latest');
