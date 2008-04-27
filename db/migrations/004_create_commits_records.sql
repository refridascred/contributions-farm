-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (count, ratio, active, state, region) VALUES (33, 70.33, 41, 'edge', 'local');
INSERT INTO commits_records (count, ratio, active, state, region) VALUES (73, 60.28, 63, 'blue', 'standard');
INSERT INTO commits_records (count, ratio, active, state, region) VALUES (74, 37.38, 20, 'edge', 'primary');
