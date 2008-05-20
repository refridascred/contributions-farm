-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (region, ratio, score, state) VALUES ('edge', 0.88, 34.48, 'open');
INSERT INTO commits_records (region, ratio, score, state) VALUES ('stable', 43.91, 3.43, 'open');
INSERT INTO commits_records (region, ratio, score, state) VALUES ('primary', 77.29, 78.04, 'eu-west');
