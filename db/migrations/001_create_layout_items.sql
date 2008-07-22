-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, active, level, weight, count) VALUES (9, 28, 27, 95.82, 52);
INSERT INTO layout_items (rank, active, level, weight, count) VALUES (62, 44, 64, 69.14, 71);
