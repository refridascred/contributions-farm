-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (score, count, rank, state) VALUES (97.38, 17, 6, 'blue');
INSERT INTO commits_records (score, count, rank, state) VALUES (51.5, 91, 50, 'standard');
INSERT INTO commits_records (score, count, rank, state) VALUES (67.32, 45, 86, 'primary');
