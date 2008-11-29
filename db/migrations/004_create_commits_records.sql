-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    rank INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (active, owner, rank, ratio, state) VALUES (97, 'green', 63, 17.65, 'fallback');
INSERT INTO commits_records (active, owner, rank, ratio, state) VALUES (75, 'edge', 29, 40.33, 'legacy');
