-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, active, rank, count, weight) VALUES ('standard', 39, 0, 47, 10.89);
INSERT INTO commits_records (state, active, rank, count, weight) VALUES ('cached', 66, 81, 40, 45.0);
INSERT INTO commits_records (state, active, rank, count, weight) VALUES ('latest', 69, 33, 7, 29.99);
