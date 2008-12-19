-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    rank INTEGER,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (state, weight, rank, level, active) VALUES ('edge', 16.98, 59, 23, 32);
INSERT INTO commits_records (state, weight, rank, level, active) VALUES ('fallback', 93.72, 59, 22, 30);
INSERT INTO commits_records (state, weight, rank, level, active) VALUES ('primary', 8.95, 43, 41, 6);
