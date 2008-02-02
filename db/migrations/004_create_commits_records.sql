-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (rank, state, token, active, weight) VALUES (35, 'edge', 'local', 78, 89.09);
INSERT INTO commits_records (rank, state, token, active, weight) VALUES (55, 'open', 'eu-west', 26, 69.72);
INSERT INTO commits_records (rank, state, token, active, weight) VALUES (8, 'legacy', 'open', 94, 4.75);
