-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (ratio, weight, state, active) VALUES (31.71, 84.09, 'blue', 18);
INSERT INTO commits_records (ratio, weight, state, active) VALUES (77.12, 13.54, 'primary', 69);
INSERT INTO commits_records (ratio, weight, state, active) VALUES (81.05, 59.08, 'open', 74);
