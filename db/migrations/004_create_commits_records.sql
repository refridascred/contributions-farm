-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (count, token, region, ratio, state) VALUES (53, 'local', 'standard', 3.78, 'eu-west');
INSERT INTO commits_records (count, token, region, ratio, state) VALUES (76, 'primary', 'fallback', 77.1, 'edge');
