-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, state) VALUES (43.12, 'stable');
INSERT INTO layout_items (weight, state) VALUES (46.49, 'blue');
INSERT INTO layout_items (weight, state) VALUES (55.84, 'eu-west');
