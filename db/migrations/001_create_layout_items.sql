-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (active, rank) VALUES (68, 9);
INSERT INTO layout_items (active, rank) VALUES (40, 13);
INSERT INTO layout_items (active, rank) VALUES (49, 13);
