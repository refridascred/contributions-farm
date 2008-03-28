-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (token, rank, owner, region, state) VALUES ('standard', 30, 'edge', 'strict', 'legacy');
INSERT INTO commits_records (token, rank, owner, region, state) VALUES ('legacy', 52, 'blue', 'legacy', 'strict');
INSERT INTO commits_records (token, rank, owner, region, state) VALUES ('staging', 80, 'stable', 'standard', 'eu-west');
