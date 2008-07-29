-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (count, state, active, weight, label) VALUES (17, 'cached', 55, 50.38, 'legacy');
INSERT INTO commits_records (count, state, active, weight, label) VALUES (46, 'eu-west', 57, 43.27, 'strict');
INSERT INTO commits_records (count, state, active, weight, label) VALUES (6, 'edge', 16, 25.7, 'stable');
