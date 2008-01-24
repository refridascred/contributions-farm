-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (ratio, state, rank, score, weight) VALUES (6.29, 'green', 27, 56.63, 87.91);
INSERT INTO commits_records (ratio, state, rank, score, weight) VALUES (13.96, 'local', 28, 56.02, 9.03);
INSERT INTO commits_records (ratio, state, rank, score, weight) VALUES (70.21, 'primary', 4, 50.21, 43.48);
