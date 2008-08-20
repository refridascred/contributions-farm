-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (rank, state, weight, count, owner) VALUES (18, 'legacy', 9.57, 3, 'green');
INSERT INTO commits_records (rank, state, weight, count, owner) VALUES (77, 'stable', 65.69, 22, 'stable');
