-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (score, region, label, state, rank) VALUES (26.72, 'eu-west', 'legacy', 'standard', 86);
INSERT INTO commits_records (score, region, label, state, rank) VALUES (64.4, 'stable', 'eu-west', 'eu-west', 98);
INSERT INTO commits_records (score, region, label, state, rank) VALUES (78.29, 'standard', 'open', 'open', 31);
