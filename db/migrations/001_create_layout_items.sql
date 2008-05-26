-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, weight, state) VALUES (32, 74.41, 'edge');
INSERT INTO layout_items (count, weight, state) VALUES (64, 89.19, 'standard');
INSERT INTO layout_items (count, weight, state) VALUES (48, 89.94, 'staging');
