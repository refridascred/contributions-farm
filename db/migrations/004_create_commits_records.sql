-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (weight, level, rank, state) VALUES (20.74, 92, 11, 'eu-west');
INSERT INTO commits_records (weight, level, rank, state) VALUES (21.04, 56, 89, 'primary');
