-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (score, owner, count) VALUES (9.96, 'green', 95);
INSERT INTO commits_records (score, owner, count) VALUES (74.81, 'strict', 26);
INSERT INTO commits_records (score, owner, count) VALUES (7.22, 'cached', 45);
