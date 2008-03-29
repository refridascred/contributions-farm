-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (ratio, rank, state, weight, score) VALUES (50.87, 18, 'latest', 77.5, 33.16);
INSERT INTO commits_records (ratio, rank, state, weight, score) VALUES (72.6, 32, 'latest', 4.17, 14.02);
INSERT INTO commits_records (ratio, rank, state, weight, score) VALUES (70.19, 62, 'open', 55.78, 21.97);
