-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (active, state, weight) VALUES (38, 'primary', 50.73);
INSERT INTO commits_records (active, state, weight) VALUES (56, 'open', 60.23);
INSERT INTO commits_records (active, state, weight) VALUES (9, 'stable', 14.79);
