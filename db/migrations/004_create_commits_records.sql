-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (ratio, state, region, owner) VALUES (23.71, 'local', 'local', 'fallback');
INSERT INTO commits_records (ratio, state, region, owner) VALUES (56.27, 'staging', 'green', 'open');
INSERT INTO commits_records (ratio, state, region, owner) VALUES (93.17, 'eu-west', 'green', 'green');
