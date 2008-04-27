-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (state, ratio, score, region) VALUES ('legacy', 80.64, 59.86, 'eu-west');
INSERT INTO commits_records (state, ratio, score, region) VALUES ('eu-west', 8.09, 3.92, 'green');
INSERT INTO commits_records (state, ratio, score, region) VALUES ('stable', 37.37, 34.02, 'fallback');
