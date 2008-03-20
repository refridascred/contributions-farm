-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (owner, state, count, weight, region) VALUES ('edge', 'local', 24, 39.58, 'staging');
INSERT INTO commits_records (owner, state, count, weight, region) VALUES ('staging', 'strict', 91, 72.85, 'eu-west');
