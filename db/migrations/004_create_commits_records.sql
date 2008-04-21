-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (active, weight, score, token, rank) VALUES (61, 35.74, 63.69, 'standard', 76);
INSERT INTO commits_records (active, weight, score, token, rank) VALUES (18, 60.98, 25.62, 'open', 21);
INSERT INTO commits_records (active, weight, score, token, rank) VALUES (79, 81.4, 42.21, 'blue', 13);
