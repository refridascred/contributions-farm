-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (active, level, weight, state, token) VALUES (51, 5, 77.83, 'stable', 'open');
INSERT INTO commits_records (active, level, weight, state, token) VALUES (30, 24, 76.69, 'blue', 'staging');
INSERT INTO commits_records (active, level, weight, state, token) VALUES (27, 56, 42.61, 'primary', 'latest');
