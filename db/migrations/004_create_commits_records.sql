-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    label TEXT,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, ratio, label, weight, level) VALUES ('green', 42.22, 'local', 8.59, 71);
INSERT INTO commits_records (state, ratio, label, weight, level) VALUES ('local', 70.35, 'edge', 44.54, 26);
