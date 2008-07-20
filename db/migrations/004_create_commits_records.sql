-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (score, ratio, region, state) VALUES (87.14, 70.14, 'strict', 'edge');
INSERT INTO commits_records (score, ratio, region, state) VALUES (55.78, 48.95, 'staging', 'staging');
INSERT INTO commits_records (score, ratio, region, state) VALUES (17.08, 89.81, 'cached', 'fallback');
