-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, active, weight, level, rank) VALUES ('primary', 36, 45.34, 19, 90);
INSERT INTO commits_records (state, active, weight, level, rank) VALUES ('stable', 59, 44.4, 75, 10);
