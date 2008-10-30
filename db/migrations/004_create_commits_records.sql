-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (weight, state, token, ratio) VALUES (89.81, 'local', 'open', 6.54);
INSERT INTO commits_records (weight, state, token, ratio) VALUES (90.31, 'fallback', 'stable', 69.47);
