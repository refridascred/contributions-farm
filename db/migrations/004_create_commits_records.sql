-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (score, weight, rank, active, owner) VALUES (93.83, 61.03, 53, 9, 'strict');
INSERT INTO commits_records (score, weight, rank, active, owner) VALUES (30.69, 98.47, 30, 53, 'stable');
