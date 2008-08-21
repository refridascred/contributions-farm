-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (owner, state, region, level) VALUES ('stable', 'cached', 'cached', 45);
INSERT INTO commits_records (owner, state, region, level) VALUES ('open', 'staging', 'staging', 53);
