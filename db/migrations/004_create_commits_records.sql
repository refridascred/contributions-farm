-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (count, active, ratio, state, level) VALUES (81, 5, 11.29, 'fallback', 1);
INSERT INTO commits_records (count, active, ratio, state, level) VALUES (96, 53, 87.31, 'green', 83);
INSERT INTO commits_records (count, active, ratio, state, level) VALUES (21, 17, 6.2, 'green', 40);
