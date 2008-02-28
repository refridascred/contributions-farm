-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (level, state, ratio, rank) VALUES (31, 'open', 19.79, 7);
INSERT INTO commits_records (level, state, ratio, rank) VALUES (15, 'green', 11.3, 22);
