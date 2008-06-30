-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (active, ratio, state, count) VALUES (55, 63.61, 'edge', 90);
INSERT INTO commits_records (active, ratio, state, count) VALUES (99, 42.78, 'edge', 73);
INSERT INTO commits_records (active, ratio, state, count) VALUES (41, 3.62, 'blue', 74);
