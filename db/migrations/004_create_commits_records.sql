-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, rank, state, ratio, owner) VALUES (89.4, 93, 'open', 83.6, 'local');
INSERT INTO commits_records (weight, rank, state, ratio, owner) VALUES (14.04, 35, 'edge', 59.5, 'latest');
INSERT INTO commits_records (weight, rank, state, ratio, owner) VALUES (31.13, 81, 'primary', 7.37, 'strict');
