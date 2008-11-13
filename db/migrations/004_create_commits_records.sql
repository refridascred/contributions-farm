-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (score, region, state, rank, weight) VALUES (51.74, 'local', 'fallback', 76, 75.53);
INSERT INTO commits_records (score, region, state, rank, weight) VALUES (45.34, 'local', 'standard', 13, 92.79);
INSERT INTO commits_records (score, region, state, rank, weight) VALUES (90.63, 'open', 'cached', 97, 53.79);
