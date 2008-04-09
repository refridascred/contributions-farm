-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, owner, ratio, count) VALUES (23.98, 'local', 74.3, 81);
INSERT INTO commits_records (score, owner, ratio, count) VALUES (36.86, 'staging', 13.55, 13);
INSERT INTO commits_records (score, owner, ratio, count) VALUES (22.13, 'blue', 7.63, 96);
