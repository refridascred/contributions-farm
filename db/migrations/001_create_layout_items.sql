-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (weight, rank, owner, active, score) VALUES (91.97, 82, 'staging', 1, 40.87);
INSERT INTO layout_items (weight, rank, owner, active, score) VALUES (20.01, 98, 'cached', 69, 39.11);
INSERT INTO layout_items (weight, rank, owner, active, score) VALUES (7.3, 29, 'legacy', 48, 44.59);
