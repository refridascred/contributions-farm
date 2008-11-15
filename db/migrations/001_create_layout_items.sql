-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, rank, weight) VALUES (8, 5, 87.97);
INSERT INTO layout_items (active, rank, weight) VALUES (89, 20, 48.34);
INSERT INTO layout_items (active, rank, weight) VALUES (93, 22, 71.95);
