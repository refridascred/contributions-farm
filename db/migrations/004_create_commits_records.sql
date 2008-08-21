-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (level, count, label, state, weight) VALUES (74, 24, 'edge', 'eu-west', 89.23);
INSERT INTO commits_records (level, count, label, state, weight) VALUES (69, 73, 'cached', 'blue', 64.03);
INSERT INTO commits_records (level, count, label, state, weight) VALUES (43, 17, 'legacy', 'fallback', 23.21);
