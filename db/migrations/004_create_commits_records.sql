-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (ratio, level, state, active, owner) VALUES (2.75, 13, 'strict', 68, 'latest');
INSERT INTO commits_records (ratio, level, state, active, owner) VALUES (47.09, 79, 'primary', 95, 'eu-west');
