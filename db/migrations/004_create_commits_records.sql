-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    weight REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (active, token, weight, rank, state) VALUES (96, 'primary', 40.61, 64, 'strict');
INSERT INTO commits_records (active, token, weight, rank, state) VALUES (22, 'cached', 45.15, 8, 'green');
INSERT INTO commits_records (active, token, weight, rank, state) VALUES (63, 'strict', 50.67, 44, 'green');
