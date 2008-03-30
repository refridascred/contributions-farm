-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (weight, count, state, label, region) VALUES (66.87, 99, 'local', 'green', 'staging');
INSERT INTO commits_records (weight, count, state, label, region) VALUES (74.33, 87, 'green', 'fallback', 'primary');
