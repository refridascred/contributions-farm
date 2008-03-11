-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (level, score, state, rank, region) VALUES (45, 56.81, 'legacy', 49, 'strict');
INSERT INTO commits_records (level, score, state, rank, region) VALUES (96, 3.62, 'legacy', 87, 'cached');
