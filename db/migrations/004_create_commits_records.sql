-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (state, ratio, region, score, weight) VALUES ('fallback', 2.92, 'strict', 34.76, 93.63);
INSERT INTO commits_records (state, ratio, region, score, weight) VALUES ('cached', 28.6, 'legacy', 48.92, 10.43);
INSERT INTO commits_records (state, ratio, region, score, weight) VALUES ('strict', 82.7, 'legacy', 70.1, 51.47);
