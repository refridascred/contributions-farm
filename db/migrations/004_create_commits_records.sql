-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (ratio, state, count, level, label) VALUES (95.81, 'edge', 29, 63, 'fallback');
INSERT INTO commits_records (ratio, state, count, level, label) VALUES (84.38, 'primary', 13, 22, 'local');
