-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    region TEXT,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, region, owner, ratio) VALUES ('staging', 'latest', 'eu-west', 62.19);
INSERT INTO commits_records (state, region, owner, ratio) VALUES ('fallback', 'local', 'green', 67.64);
INSERT INTO commits_records (state, region, owner, ratio) VALUES ('blue', 'edge', 'green', 30.73);
