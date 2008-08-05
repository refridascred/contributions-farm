-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, active, weight) VALUES ('cached', 42, 2.65);
INSERT INTO commits_records (state, active, weight) VALUES ('standard', 62, 40.46);
INSERT INTO commits_records (state, active, weight) VALUES ('standard', 18, 97.89);
