-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (owner, score, count, rank) VALUES ('stable', 41.78, 22, 97);
INSERT INTO commits_records (owner, score, count, rank) VALUES ('stable', 26.96, 70, 97);
INSERT INTO commits_records (owner, score, count, rank) VALUES ('legacy', 13.45, 55, 94);
