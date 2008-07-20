-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (token, region, state, weight) VALUES ('legacy', 'primary', 'open', 71.64);
INSERT INTO commits_records (token, region, state, weight) VALUES ('edge', 'staging', 'fallback', 88.44);
INSERT INTO commits_records (token, region, state, weight) VALUES ('legacy', 'cached', 'latest', 96.63);
