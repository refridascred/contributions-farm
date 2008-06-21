-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    token TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, weight, token, ratio, state) VALUES (48, 25.66, 'green', 71.25, 'stable');
INSERT INTO commits_records (active, weight, token, ratio, state) VALUES (56, 34.6, 'edge', 3.1, 'primary');
