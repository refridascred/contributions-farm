-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (state, level, count, rank, score) VALUES ('standard', 11, 89, 73, 14.77);
INSERT INTO commits_records (state, level, count, rank, score) VALUES ('standard', 99, 49, 76, 41.18);
INSERT INTO commits_records (state, level, count, rank, score) VALUES ('green', 50, 1, 70, 52.43);
