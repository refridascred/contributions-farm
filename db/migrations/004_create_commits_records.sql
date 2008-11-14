-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (ratio, label, region, state) VALUES (37.75, 'standard', 'green', 'standard');
INSERT INTO commits_records (ratio, label, region, state) VALUES (6.42, 'open', 'eu-west', 'strict');
INSERT INTO commits_records (ratio, label, region, state) VALUES (59.52, 'fallback', 'primary', 'primary');
