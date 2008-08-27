-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (owner, level, region, label) VALUES ('strict', 67, 'open', 'fallback');
INSERT INTO commits_records (owner, level, region, label) VALUES ('edge', 23, 'staging', 'legacy');
