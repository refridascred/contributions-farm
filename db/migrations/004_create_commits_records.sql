-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (state, score, region, rank) VALUES ('standard', 59.37, 'green', 8);
INSERT INTO commits_records (state, score, region, rank) VALUES ('staging', 98.19, 'primary', 55);
INSERT INTO commits_records (state, score, region, rank) VALUES ('edge', 65.9, 'legacy', 51);
