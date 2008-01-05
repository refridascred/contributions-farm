-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (rank, ratio, state, region, token) VALUES (41, 64.77, 'blue', 'legacy', 'staging');
INSERT INTO commits_records (rank, ratio, state, region, token) VALUES (13, 53.96, 'legacy', 'staging', 'open');
INSERT INTO commits_records (rank, ratio, state, region, token) VALUES (11, 46.68, 'edge', 'local', 'staging');
