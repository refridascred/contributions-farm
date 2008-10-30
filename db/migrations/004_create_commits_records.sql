-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (state, region, ratio, count, label) VALUES ('latest', 'standard', 24.74, 74, 'stable');
INSERT INTO commits_records (state, region, ratio, count, label) VALUES ('stable', 'green', 14.51, 69, 'primary');
