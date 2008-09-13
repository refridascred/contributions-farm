-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (state, score, ratio, region) VALUES ('cached', 57.01, 80.91, 'primary');
INSERT INTO commits_records (state, score, ratio, region) VALUES ('cached', 59.41, 72.4, 'edge');
INSERT INTO commits_records (state, score, ratio, region) VALUES ('legacy', 49.87, 55.73, 'cached');
