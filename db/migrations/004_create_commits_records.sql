-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (ratio, weight, label, state, token) VALUES (10.65, 80.82, 'fallback', 'primary', 'fallback');
INSERT INTO commits_records (ratio, weight, label, state, token) VALUES (23.67, 63.14, 'standard', 'fallback', 'open');
INSERT INTO commits_records (ratio, weight, label, state, token) VALUES (45.62, 94.25, 'standard', 'standard', 'strict');
