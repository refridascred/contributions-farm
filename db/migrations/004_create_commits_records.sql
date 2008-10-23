-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (weight, rank, score, owner) VALUES (26.46, 58, 4.18, 'strict');
INSERT INTO commits_records (weight, rank, score, owner) VALUES (92.89, 19, 29.65, 'staging');
INSERT INTO commits_records (weight, rank, score, owner) VALUES (52.51, 17, 85.28, 'edge');
