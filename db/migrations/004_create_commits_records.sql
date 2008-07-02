-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (label, weight, state, region) VALUES ('eu-west', 7.77, 'edge', 'blue');
INSERT INTO commits_records (label, weight, state, region) VALUES ('primary', 85.57, 'standard', 'blue');
INSERT INTO commits_records (label, weight, state, region) VALUES ('blue', 29.25, 'blue', 'strict');
