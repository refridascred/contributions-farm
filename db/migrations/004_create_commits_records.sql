-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (ratio, token, owner, count) VALUES (88.46, 'legacy', 'green', 80);
INSERT INTO commits_records (ratio, token, owner, count) VALUES (63.09, 'cached', 'green', 21);
