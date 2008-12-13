-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (weight, owner, state, rank) VALUES (44.33, 'standard', 'primary', 99);
INSERT INTO commits_records (weight, owner, state, rank) VALUES (38.25, 'stable', 'cached', 95);
INSERT INTO commits_records (weight, owner, state, rank) VALUES (86.84, 'stable', 'open', 52);
