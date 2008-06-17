-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (state, score, level, ratio) VALUES ('latest', 31.27, 64, 71.02);
INSERT INTO commits_records (state, score, level, ratio) VALUES ('edge', 39.81, 67, 6.02);
INSERT INTO commits_records (state, score, level, ratio) VALUES ('legacy', 9.2, 2, 43.37);
