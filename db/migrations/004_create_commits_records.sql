-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (weight, active, state) VALUES (78.34, 74, 'fallback');
INSERT INTO commits_records (weight, active, state) VALUES (34.95, 19, 'primary');
INSERT INTO commits_records (weight, active, state) VALUES (90.25, 60, 'cached');
