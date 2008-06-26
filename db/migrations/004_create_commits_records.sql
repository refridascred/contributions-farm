-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (state, score, rank, ratio) VALUES ('standard', 90.26, 36, 66.75);
INSERT INTO commits_records (state, score, rank, ratio) VALUES ('standard', 89.5, 6, 38.36);
