-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (rank, region, owner, score) VALUES (95, 'stable', 'standard', 65.39);
INSERT INTO commits_records (rank, region, owner, score) VALUES (23, 'standard', 'blue', 92.28);
