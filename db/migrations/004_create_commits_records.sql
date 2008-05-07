-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (label, state, active, weight) VALUES ('open', 'latest', 31, 19.65);
INSERT INTO commits_records (label, state, active, weight) VALUES ('legacy', 'edge', 26, 18.99);
INSERT INTO commits_records (label, state, active, weight) VALUES ('primary', 'standard', 38, 95.23);
