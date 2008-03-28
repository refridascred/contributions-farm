-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (rank, label, state, weight) VALUES (87, 'green', 'legacy', 33.66);
INSERT INTO commits_records (rank, label, state, weight) VALUES (83, 'strict', 'eu-west', 49.4);
