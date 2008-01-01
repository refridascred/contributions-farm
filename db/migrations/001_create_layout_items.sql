-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (active, weight, label, rank) VALUES (67, 59.11, 'strict', 65);
INSERT INTO layout_items (active, weight, label, rank) VALUES (94, 73.64, 'stable', 80);
INSERT INTO layout_items (active, weight, label, rank) VALUES (10, 68.14, 'fallback', 15);
