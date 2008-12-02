-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (active, state, score, weight) VALUES (89, 'blue', 64.79, 0.89);
INSERT INTO commits_records (active, state, score, weight) VALUES (75, 'eu-west', 4.3, 74.01);
INSERT INTO commits_records (active, state, score, weight) VALUES (58, 'primary', 91.44, 50.65);
