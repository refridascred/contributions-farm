-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    weight REAL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (level, label, weight, ratio, state) VALUES (2, 'stable', 44.19, 7.62, 'primary');
INSERT INTO commits_records (level, label, weight, ratio, state) VALUES (33, 'primary', 39.89, 28.18, 'blue');
