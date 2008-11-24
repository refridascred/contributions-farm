-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (label, weight, owner, score, rank) VALUES ('fallback', 48.74, 'stable', 76.42, 84);
INSERT INTO commits_records (label, weight, owner, score, rank) VALUES ('open', 8.09, 'strict', 33.61, 88);
