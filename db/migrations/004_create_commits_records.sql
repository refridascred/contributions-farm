-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, count, active) VALUES ('green', 24, 23);
INSERT INTO commits_records (state, count, active) VALUES ('legacy', 91, 42);
INSERT INTO commits_records (state, count, active) VALUES ('open', 19, 28);
