-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (ratio, count, state, weight, level) VALUES (90.33, 68, 'stable', 44.46, 78);
INSERT INTO commits_records (ratio, count, state, weight, level) VALUES (41.88, 4, 'staging', 85.97, 73);
INSERT INTO commits_records (ratio, count, state, weight, level) VALUES (61.45, 30, 'fallback', 8.28, 91);
