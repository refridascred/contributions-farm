-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, owner, score) VALUES (47, 'stable', 25.78);
INSERT INTO commits_records (count, owner, score) VALUES (15, 'local', 92.15);
INSERT INTO commits_records (count, owner, score) VALUES (3, 'cached', 12.14);
