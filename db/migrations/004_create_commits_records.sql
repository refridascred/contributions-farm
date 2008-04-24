-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (count, weight, rank, state) VALUES (16, 29.91, 2, 'green');
INSERT INTO commits_records (count, weight, rank, state) VALUES (55, 67.8, 37, 'green');
INSERT INTO commits_records (count, weight, rank, state) VALUES (64, 11.42, 95, 'stable');
