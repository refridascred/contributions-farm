-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (active, state, ratio, count) VALUES (0, 'primary', 82.75, 57);
INSERT INTO commits_records (active, state, ratio, count) VALUES (13, 'green', 95.68, 80);
INSERT INTO commits_records (active, state, ratio, count) VALUES (7, 'local', 97.0, 20);
