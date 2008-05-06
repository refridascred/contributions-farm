-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (rank, score, region, owner, state) VALUES (10, 85.68, 'staging', 'cached', 'latest');
INSERT INTO commits_records (rank, score, region, owner, state) VALUES (98, 6.1, 'stable', 'legacy', 'legacy');
