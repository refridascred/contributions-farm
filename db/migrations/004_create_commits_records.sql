-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (count, score, state, level) VALUES (43, 46.42, 'latest', 84);
INSERT INTO commits_records (count, score, state, level) VALUES (19, 5.74, 'stable', 51);
INSERT INTO commits_records (count, score, state, level) VALUES (68, 42.37, 'legacy', 87);
