-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, level, ratio, state, active) VALUES (51, 85, 52.2, 'open', 32);
INSERT INTO commits_records (count, level, ratio, state, active) VALUES (69, 87, 46.13, 'edge', 85);
INSERT INTO commits_records (count, level, ratio, state, active) VALUES (22, 69, 71.3, 'open', 51);
