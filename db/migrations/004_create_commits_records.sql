-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    region TEXT,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (state, rank, region, ratio, owner) VALUES ('stable', 10, 'cached', 2.07, 'staging');
INSERT INTO commits_records (state, rank, region, ratio, owner) VALUES ('fallback', 91, 'stable', 74.78, 'open');
INSERT INTO commits_records (state, rank, region, ratio, owner) VALUES ('local', 81, 'legacy', 49.43, 'eu-west');
