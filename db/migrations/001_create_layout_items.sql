-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, state, owner) VALUES (80.02, 'latest', 'edge');
INSERT INTO layout_items (weight, state, owner) VALUES (5.62, 'fallback', 'local');
INSERT INTO layout_items (weight, state, owner) VALUES (64.91, 'strict', 'edge');
