-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (rank, state, level, score, count) VALUES (29, 'standard', 61, 52.51, 45);
INSERT INTO commits_records (rank, state, level, score, count) VALUES (1, 'blue', 45, 88.05, 9);
INSERT INTO commits_records (rank, state, level, score, count) VALUES (53, 'cached', 97, 75.68, 87);
