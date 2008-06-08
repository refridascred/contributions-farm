-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (weight, rank, state, level) VALUES (73.08, 72, 'legacy', 38);
INSERT INTO commits_records (weight, rank, state, level) VALUES (91.36, 6, 'open', 22);
INSERT INTO commits_records (weight, rank, state, level) VALUES (68.73, 36, 'staging', 86);
