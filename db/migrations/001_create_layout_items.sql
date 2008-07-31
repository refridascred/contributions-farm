-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (state, weight) VALUES ('latest', 56.6);
INSERT INTO layout_items (state, weight) VALUES ('open', 74.21);
INSERT INTO layout_items (state, weight) VALUES ('cached', 56.28);
