-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (weight, score, rank, ratio, state) VALUES (55.36, 55.76, 75, 69.03, 'green');
INSERT INTO commits_records (weight, score, rank, ratio, state) VALUES (52.09, 6.19, 57, 73.41, 'local');
