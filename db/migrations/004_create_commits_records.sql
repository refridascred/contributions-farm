-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (count, ratio, rank, active, state) VALUES (57, 19.2, 75, 59, 'blue');
INSERT INTO commits_records (count, ratio, rank, active, state) VALUES (38, 18.39, 27, 62, 'cached');
INSERT INTO commits_records (count, ratio, rank, active, state) VALUES (50, 98.17, 70, 5, 'standard');
