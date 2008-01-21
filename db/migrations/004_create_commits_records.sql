-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (region, level, state, rank, active) VALUES ('stable', 71, 'stable', 8, 30);
INSERT INTO commits_records (region, level, state, rank, active) VALUES ('local', 72, 'primary', 51, 35);
