-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    owner TEXT NOT NULL,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (level, label, owner, rank, weight) VALUES (17, 'fallback', 'staging', 48, 4.82);
INSERT INTO commits_records (level, label, owner, rank, weight) VALUES (18, 'edge', 'edge', 43, 6.13);
INSERT INTO commits_records (level, label, owner, rank, weight) VALUES (64, 'strict', 'latest', 35, 36.41);
