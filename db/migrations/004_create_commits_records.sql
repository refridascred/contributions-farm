-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, owner, count) VALUES (38.37, 'open', 14);
INSERT INTO commits_records (score, owner, count) VALUES (7.06, 'staging', 15);
INSERT INTO commits_records (score, owner, count) VALUES (91.4, 'latest', 47);
