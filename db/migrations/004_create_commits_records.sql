-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (active, level, rank, state, ratio) VALUES (6, 10, 28, 'legacy', 28.13);
INSERT INTO commits_records (active, level, rank, state, ratio) VALUES (2, 67, 34, 'blue', 34.74);
