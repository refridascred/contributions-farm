-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, score, level, count) VALUES (22, 24.69, 68, 73);
INSERT INTO commits_records (rank, score, level, count) VALUES (87, 24.37, 44, 61);
INSERT INTO commits_records (rank, score, level, count) VALUES (10, 30.3, 81, 38);
