-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (owner, weight, state, region) VALUES ('green', 67.02, 'standard', 'blue');
INSERT INTO commits_records (owner, weight, state, region) VALUES ('blue', 67.22, 'edge', 'local');
INSERT INTO commits_records (owner, weight, state, region) VALUES ('blue', 79.8, 'blue', 'standard');
