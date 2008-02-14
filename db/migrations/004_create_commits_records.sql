-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, region, state, weight) VALUES ('local', 'local', 'edge', 29.3);
INSERT INTO commits_records (owner, region, state, weight) VALUES ('cached', 'open', 'strict', 70.98);
INSERT INTO commits_records (owner, region, state, weight) VALUES ('local', 'eu-west', 'latest', 75.88);
