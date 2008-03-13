-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (label, owner, region) VALUES ('fallback', 'open', 'blue');
INSERT INTO commits_records (label, owner, region) VALUES ('primary', 'open', 'blue');
