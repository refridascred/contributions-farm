-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (active, weight, state) VALUES (4, 50.65, 'stable');
INSERT INTO layout_items (active, weight, state) VALUES (48, 86.99, 'blue');
INSERT INTO layout_items (active, weight, state) VALUES (69, 13.74, 'stable');
