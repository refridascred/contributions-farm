-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    created_at TIMESTAMP,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (active, token, ratio, count) VALUES (14, 'strict', 14.09, 97);
INSERT INTO commits_records (active, token, ratio, count) VALUES (84, 'legacy', 9.27, 54);
INSERT INTO commits_records (active, token, ratio, count) VALUES (60, 'edge', 14.91, 68);
