-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (count, weight, owner, state, token) VALUES (78, 2.8, 'green', 'strict', 'strict');
INSERT INTO commits_records (count, weight, owner, state, token) VALUES (94, 28.17, 'green', 'primary', 'local');
