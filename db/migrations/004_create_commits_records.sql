-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (level, region, weight, state) VALUES (26, 'fallback', 55.17, 'edge');
INSERT INTO commits_records (level, region, weight, state) VALUES (9, 'open', 4.58, 'latest');
