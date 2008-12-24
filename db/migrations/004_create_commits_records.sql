-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    token TEXT,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (score, label, token, region, rank) VALUES (96.75, 'open', 'edge', 'legacy', 19);
INSERT INTO commits_records (score, label, token, region, rank) VALUES (38.11, 'green', 'legacy', 'open', 80);
INSERT INTO commits_records (score, label, token, region, rank) VALUES (36.68, 'cached', 'green', 'cached', 86);
