-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    region TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (ratio, level, region, rank, state) VALUES (87.48, 90, 'standard', 44, 'staging');
INSERT INTO commits_records (ratio, level, region, rank, state) VALUES (56.55, 25, 'edge', 56, 'legacy');
