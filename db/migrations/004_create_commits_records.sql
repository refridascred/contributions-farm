-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (state, region, owner) VALUES ('cached', 'staging', 'cached');
INSERT INTO commits_records (state, region, owner) VALUES ('open', 'eu-west', 'staging');
INSERT INTO commits_records (state, region, owner) VALUES ('local', 'edge', 'legacy');
