-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (active, count, score) VALUES (19, 33, 10.12);
INSERT INTO commits_records (active, count, score) VALUES (48, 24, 85.29);
INSERT INTO commits_records (active, count, score) VALUES (27, 65, 7.59);
