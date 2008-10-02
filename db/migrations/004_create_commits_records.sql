-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    ratio REAL,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (state, weight, ratio, level, region) VALUES ('edge', 68.31, 53.01, 77, 'cached');
INSERT INTO commits_records (state, weight, ratio, level, region) VALUES ('stable', 69.33, 0.08, 4, 'standard');
