-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (rank, score, state, weight) VALUES (42, 24.89, 'eu-west', 25.52);
INSERT INTO commits_records (rank, score, state, weight) VALUES (94, 83.58, 'edge', 35.23);
INSERT INTO commits_records (rank, score, state, weight) VALUES (79, 55.06, 'stable', 76.08);
