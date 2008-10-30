-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (ratio, state, active, weight) VALUES (63.39, 'primary', 32, 46.06);
INSERT INTO commits_records (ratio, state, active, weight) VALUES (31.93, 'open', 96, 11.31);
INSERT INTO commits_records (ratio, state, active, weight) VALUES (28.55, 'primary', 82, 32.47);
