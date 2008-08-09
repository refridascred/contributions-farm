-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, region, state, weight) VALUES ('open', 'eu-west', 'legacy', 81.55);
INSERT INTO commits_records (token, region, state, weight) VALUES ('primary', 'staging', 'eu-west', 52.22);
