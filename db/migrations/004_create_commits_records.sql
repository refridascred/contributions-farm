-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (active, level, rank, score) VALUES (85, 86, 86, 54.29);
INSERT INTO commits_records (active, level, rank, score) VALUES (69, 93, 61, 6.84);
INSERT INTO commits_records (active, level, rank, score) VALUES (71, 86, 41, 78.65);
