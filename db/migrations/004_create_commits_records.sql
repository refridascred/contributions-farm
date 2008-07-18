-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    label TEXT,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (owner, weight, label, rank, token) VALUES ('cached', 17.58, 'fallback', 49, 'stable');
INSERT INTO commits_records (owner, weight, label, rank, token) VALUES ('edge', 78.86, 'stable', 47, 'local');
INSERT INTO commits_records (owner, weight, label, rank, token) VALUES ('primary', 70.34, 'fallback', 43, 'strict');
