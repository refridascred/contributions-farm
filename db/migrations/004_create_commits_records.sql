-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    region TEXT,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (state, weight, region, label) VALUES ('open', 83.21, 'stable', 'latest');
INSERT INTO commits_records (state, weight, region, label) VALUES ('eu-west', 37.09, 'open', 'local');
