-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (token, count, state, weight, active) VALUES ('legacy', 75, 'fallback', 43.19, 83);
INSERT INTO commits_records (token, count, state, weight, active) VALUES ('blue', 26, 'open', 71.01, 0);
