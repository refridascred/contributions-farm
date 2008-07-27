-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (region, weight, token, state, active) VALUES ('standard', 61.33, 'green', 'open', 71);
INSERT INTO commits_records (region, weight, token, state, active) VALUES ('fallback', 71.78, 'primary', 'edge', 58);
INSERT INTO commits_records (region, weight, token, state, active) VALUES ('cached', 59.67, 'primary', 'primary', 93);
