-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (active, rank) VALUES (95, 52);
INSERT INTO layout_items (active, rank) VALUES (14, 24);
INSERT INTO layout_items (active, rank) VALUES (48, 92);
