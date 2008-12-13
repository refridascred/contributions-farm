-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (level, rank, weight, active, owner) VALUES (20, 75, 97.37, 84, 'legacy');
INSERT INTO layout_items (level, rank, weight, active, owner) VALUES (85, 11, 70.48, 39, 'open');
