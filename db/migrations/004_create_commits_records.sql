-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    token TEXT,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (state, ratio, token, region, weight) VALUES ('edge', 58.77, 'eu-west', 'fallback', 79.41);
INSERT INTO commits_records (state, ratio, token, region, weight) VALUES ('open', 15.54, 'cached', 'green', 70.97);
