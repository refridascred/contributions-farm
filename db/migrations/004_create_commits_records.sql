-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (active, region, score, state, ratio) VALUES (97, 'latest', 30.43, 'stable', 83.52);
INSERT INTO commits_records (active, region, score, state, ratio) VALUES (54, 'strict', 17.37, 'standard', 50.55);
