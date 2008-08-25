-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    level INTEGER,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (state, ratio, level, owner, active) VALUES ('edge', 10.48, 71, 'strict', 89);
INSERT INTO commits_records (state, ratio, level, owner, active) VALUES ('primary', 15.23, 1, 'local', 65);
INSERT INTO commits_records (state, ratio, level, owner, active) VALUES ('local', 40.64, 45, 'standard', 35);
