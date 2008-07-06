-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (state, score, region, level) VALUES ('strict', 85.33, 'legacy', 2);
INSERT INTO commits_records (state, score, region, level) VALUES ('local', 29.55, 'standard', 13);
