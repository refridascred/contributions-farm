-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (ratio, region, owner, state) VALUES (52.89, 'cached', 'open', 'legacy');
INSERT INTO commits_records (ratio, region, owner, state) VALUES (92.88, 'cached', 'standard', 'cached');
