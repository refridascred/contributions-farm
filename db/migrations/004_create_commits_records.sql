-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (score, weight, state, level) VALUES (80.45, 66.23, 'primary', 1);
INSERT INTO commits_records (score, weight, state, level) VALUES (55.54, 81.12, 'fallback', 76);
