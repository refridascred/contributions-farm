-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, level) VALUES ('cached', 11);
INSERT INTO commits_records (state, level) VALUES ('green', 67);
INSERT INTO commits_records (state, level) VALUES ('standard', 63);
