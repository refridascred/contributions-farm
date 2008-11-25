-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, active, region) VALUES ('open', 63, 'local');
INSERT INTO commits_records (state, active, region) VALUES ('standard', 42, 'fallback');
INSERT INTO commits_records (state, active, region) VALUES ('eu-west', 80, 'eu-west');
