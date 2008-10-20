-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (active, rank, state, weight) VALUES (51, 82, 'edge', 88.63);
INSERT INTO commits_records (active, rank, state, weight) VALUES (37, 75, 'eu-west', 73.44);
INSERT INTO commits_records (active, rank, state, weight) VALUES (31, 29, 'eu-west', 13.67);
